using Apresentacao.Validacoes;
using MetroFramework.Forms;
using Modelo;
using Modelo.Enums;
using MySql;
using System;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmOS : MetroForm
    {
        CorBanco corBanco = new CorBanco();
        OSBanco oSBanco = new OSBanco();
        Status status;

        OS Modelo { get; set; }
        
        public frmOS(OS value)
        { 
            InitializeComponent();
            Modelo = value;
            status = value.StatusSelecionado;
            ComboBoxCorConfig();
            ComboBoxStatusConfig();
            DesabilitarControles();
        }

        public void ComboBoxStatusConfig()
        {
            var meusStatus = from Status valor in Enum.GetValues(typeof(Status))
                             select new { Key = valor, Value = Validacoes.Validacoes.GetEnumDescription(valor) };
            cboStatus.DisplayMember = "Value";
            cboStatus.ValueMember = "Key";
            cboStatus.DataSource = meusStatus.ToList();
        }

        public void DesabilitarControles()
        {
            bool habilitar = Modelo.Cod_ordem < 1;
            btnAparelho.Enabled = habilitar;
            btnCliente.Enabled = habilitar;
            btnCor.Enabled = habilitar;
            btnImprimirOS.Enabled = !habilitar;
            txtImeiPrimario.Enabled = habilitar;
            txtImeiSegundario.Enabled = habilitar;
            txtReclamacao.Enabled = habilitar;
            chkBateria.AutoCheck = habilitar;
            chkCapa.AutoCheck = habilitar;
            chkCartaoSD.AutoCheck = habilitar;
            chkCartaoSIM.AutoCheck = habilitar;
            chkTampa.AutoCheck = habilitar;
            if (Modelo.StatusSelecionado == Status.Aberto && Modelo.Cod_ordem < 1)
                cboStatus.Enabled = false;
            else if(Modelo.StatusSelecionado == Status.Retirado || Modelo.StatusSelecionado == Status.Devolvido)
            {
                txtDescricaoOrcamento.ReadOnly = true;
                txtPreco.ReadOnly = true;
                cboStatus.Enabled = false;
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmProcurarCliente frmProcurarCliente = new frmProcurarCliente();
            if (frmProcurarCliente.ShowDialog() == DialogResult.OK)
            {
                Modelo.ClienteSelecionado = frmProcurarCliente.ClienteSelecionado;
                errorProvider1.SetError(lblCliente, null);
            }
            else
            {
                errorProvider1.SetError(lblCliente, "Selecione um cliente");
                Modelo.ClienteSelecionado = null;
            }
            frmProcurarCliente.Dispose();
        }

        private void btnAparelho_Click(object sender, EventArgs e)
        {
            frmProcurarAparelho frmProcurarAparelho = new frmProcurarAparelho();
            if (frmProcurarAparelho.ShowDialog() == DialogResult.OK)
            {
                Modelo.AparelhoSelecionado = frmProcurarAparelho.AparelhoSelecionado;
                errorProvider1.SetError(lblModeloAparelho, null);
            }
            else
                errorProvider1.SetError(lblModeloAparelho, "Selecione um modelo para preencher os seguintes campos: Aparelho, Modelo e Marca");
            frmProcurarAparelho.Dispose();
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            frmCor frmCor = new frmCor();
            frmCor.ShowDialog();
            cboCor.DataSource = corBanco.MostrarTodos();
            frmCor.Dispose();
        }

        public void ComboBoxCorConfig()
        {
            cboCor.DataSource = corBanco.MostrarTodos();
            cboCor.DisplayMember = "Nome_cor";
            cboCor.ValueMember = "Cod_cor";
        }

        private void Binding()
        {         
            txtCliente.DataBindings.Add("Text", Modelo, "ClienteSelecionado.Nome_cliente", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAparelho.DataBindings.Add("Text", Modelo, "AparelhoSelecionado.TipoSelecionado", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDescricaoOrcamento.DataBindings.Add("Text", Modelo, "Orc_descricao", false, DataSourceUpdateMode.OnPropertyChanged);
            txtImeiPrimario.DataBindings.Add("Text", Modelo, "Imei1_aparelho", false, DataSourceUpdateMode.OnPropertyChanged);
            txtImeiSegundario.DataBindings.Add("Text", Modelo, "Imei2_aparelho", false, DataSourceUpdateMode.OnPropertyChanged);
            txtMarca.DataBindings.Add("Text", Modelo, "AparelhoSelecionado.MarcaSelecionada.Nome_marca", false, DataSourceUpdateMode.OnPropertyChanged);
            txtModeloAparelho.DataBindings.Add("Text", Modelo, "AparelhoSelecionado.Modelo_aparelho", false, DataSourceUpdateMode.OnPropertyChanged);
            txtObservacoes.DataBindings.Add("Text", Modelo, "Obs_aparelho", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPreco.DataBindings.Add("Numero", Modelo, "Orc_preco", false, DataSourceUpdateMode.OnPropertyChanged);
            txtReclamacao.DataBindings.Add("Text", Modelo, "Rec_aparelho", false, DataSourceUpdateMode.OnPropertyChanged);
            cboCor.DataBindings.Add("SelectedValue", Modelo, "CorSelecionada.Cod_cor", false, DataSourceUpdateMode.OnPropertyChanged);
            cboStatus.DataBindings.Add("SelectedValue", Modelo, "StatusSelecionado", false, DataSourceUpdateMode.OnPropertyChanged);
            chkBateria.DataBindings.Add("Checked", Modelo, "Bateria", false, DataSourceUpdateMode.OnPropertyChanged);
            chkCapa.DataBindings.Add("Checked", Modelo, "Capa", false, DataSourceUpdateMode.OnPropertyChanged);
            chkCartaoSD.DataBindings.Add("Checked", Modelo, "Cartaosd", false, DataSourceUpdateMode.OnPropertyChanged);
            chkCartaoSIM.DataBindings.Add("Checked", Modelo, "Cartaosim", false, DataSourceUpdateMode.OnPropertyChanged);
            chkTampa.DataBindings.Add("Checked", Modelo, "Tampa", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                if(Modelo.Cod_ordem > 0)
                {
                    if (status != Modelo.StatusSelecionado && Modelo.StatusSelecionado == Status.Retirado)
                    {
                        frmFinalizarItem item = new frmFinalizarItem(Modelo);
                        if (item.ShowDialog() == DialogResult.OK)
                        {
                            oSBanco.AlterarOS(Modelo, true);
                            if (item.Cupom)
                                new Cupons.CupomOS(Modelo.Cod_ordem).Print();
                            MessageBox.Show("OS Contabilizada no caixa com sucesso, código: " + Modelo.Cod_ordem);
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        oSBanco.AlterarOS(Modelo, false);
                        MessageBox.Show("OS alterada com sucesso, código: " + Modelo.Cod_ordem);
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    oSBanco.InserirOS(Modelo);
                    new frmImprimirOS(Modelo.Cod_ordem).ShowDialog();
                    MessageBox.Show("OS cadastrada com sucesso, código: " + Modelo.Cod_ordem);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void txtCliente_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(Modelo.ClienteSelecionado.Nome_cliente) || Modelo.ClienteSelecionado.Cod_cliente < 1)
            {
                errorProvider1.SetError(lblCliente, "Selecione um cliente");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lblCliente, null);
                e.Cancel = false;
            }
        }

        private void txtModeloAparelho_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Modelo.AparelhoSelecionado.Modelo_aparelho) || Modelo.AparelhoSelecionado.Cod_aparelho < 1)
            {
                errorProvider1.SetError(lblModeloAparelho, "Selecione um modelo para preencher os seguintes campos: Aparelho, Modelo e Marca");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lblModeloAparelho, null);
                e.Cancel = false;
            }
        }

        private void txtReclamacao_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Modelo.Rec_aparelho))
            {
                errorProvider1.SetError(lblReclamacao, "Reclamação em branco inválida");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lblReclamacao, null);
                e.Cancel = false;
            }
        }

        private void cboCor_Validating(object sender, CancelEventArgs e)
        {
            if(cboCor.SelectedIndex < 0)
            {
                errorProvider1.SetError(lblCor, "Selecione uma cor");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lblCor, null);
                e.Cancel = false;
            }
        }

        private void frmOS_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
            Binding();
        }

        private void txtImeiPrimario_Validating(object sender, CancelEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(Modelo.Imei1_aparelho))
            {
                if(Modelo.Imei1_aparelho.Length < 15)
                {
                    errorProvider1.SetError(lblIMEI, "IMEI faltando caractéres");
                    e.Cancel = true;
                }
                else if(!Validacoes.Validacoes.ValidarIMEI(Modelo.Imei1_aparelho))
                {
                    errorProvider1.SetError(lblIMEI, "Digito verificador inválido");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(lblIMEI, null);
                    e.Cancel = false;
                }
            }
            else
            {
                errorProvider1.SetError(lblIMEI, null);
                e.Cancel = false;
            }
        }

        private void txtImeiSegundario_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Modelo.Imei2_aparelho))
            {
                if (Modelo.Imei2_aparelho.Length < 15)
                {
                    errorProvider1.SetError(lblIMEI2, "IMEI faltando caractéres");
                    e.Cancel = true;
                }
                else if (!Validacoes.Validacoes.ValidarIMEI(Modelo.Imei2_aparelho))
                {
                    errorProvider1.SetError(lblIMEI2, "Digito verificador inválido");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(lblIMEI2, null);
                    e.Cancel = false;
                }
            }
            else
            {
                errorProvider1.SetError(lblIMEI2, null);
                e.Cancel = false;
            }
        }

        private void txtPreco_Validating(object sender, CancelEventArgs e)
        {
            if(Modelo.StatusSelecionado == Status.Consertado || Modelo.StatusSelecionado == Status.Retirado)
            {
                if(Modelo.Orc_preco == decimal.Zero)
                {
                    errorProvider1.SetError(lblPreco, "Preço nulo inválido");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(lblPreco, null);
                    e.Cancel = false;
                }
            }
            else
            {
                errorProvider1.SetError(lblPreco, null);
                e.Cancel = false;
            }
        }

        private void txtDescricaoOrcamento_Validating(object sender, CancelEventArgs e)
        {
            if (Modelo.StatusSelecionado == Status.Consertado || Modelo.StatusSelecionado == Status.Retirado)
            {
                if (string.IsNullOrWhiteSpace(Modelo.Orc_descricao))
                {
                    errorProvider1.SetError(lblDescricaoOrcamento, "Orçamento em branco inválido");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(lblDescricaoOrcamento, null);
                    e.Cancel = false;
                }
            }
            else
            {
                errorProvider1.SetError(lblDescricaoOrcamento, null);
                e.Cancel = false;
            }
        }


        private void txtImeiPrimario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((!char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void btnImprimirOS_Click(object sender, EventArgs e)
        {
            frmImprimirOS imprimirOS = new frmImprimirOS(Modelo.Cod_ordem);
            imprimirOS.ShowDialog();
            imprimirOS.Dispose();
        }
    }
}
