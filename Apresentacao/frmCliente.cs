using Apresentacao.Validacoes;
using MetroFramework.Forms;
using Modelo;
using MySql;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmCliente : MetroForm
    {
        Cliente Modelo { get; set; }
        ClienteBanco clienteBanco = new ClienteBanco();
        CEPBanco cepBanco = new CEPBanco();

        public frmCliente(Cliente cliente)
        {
            InitializeComponent();
            Modelo = cliente;
        }

        private void btnCEP_Click(object sender, EventArgs e)
        {
            frmCEP frmCEP = new frmCEP(new CEP());
            frmCEP.ShowDialog();
            frmCEP.Dispose();
        }

        private void Binding()
        {
            txtNome.DataBindings.Add
                ("Text", Modelo, "Nome_cliente", false, DataSourceUpdateMode.OnPropertyChanged);
            mskCEP.DataBindings.Add
                ("Text", Modelo, "CepSelecionado.Cep", true, DataSourceUpdateMode.OnPropertyChanged).Parse += ConverterMascara;
            mskCelular.DataBindings.Add
                ("Text", Modelo, "Cel_cliente", true, DataSourceUpdateMode.OnPropertyChanged).Parse += ConverterMascara;
            mskCPF.DataBindings.Add
                ("Text", Modelo, "Cpf_cliente", true, DataSourceUpdateMode.OnPropertyChanged).Parse += ConverterMascara;
            mskTelCom.DataBindings.Add
                ("Text", Modelo, "Telcom_cliente", true, DataSourceUpdateMode.OnPropertyChanged).Parse += ConverterMascara;
            mskTelefone.DataBindings.Add
                ("Text", Modelo, "Tel_cliente", true, DataSourceUpdateMode.OnPropertyChanged).Parse += ConverterMascara;
            txtBairro.DataBindings.Add
                ("Text", Modelo, "CepSelecionado.Bairro", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add
                ("Text", Modelo, "Email_cliente", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCidade.DataBindings.Add
                ("Text", Modelo, "CepSelecionado.Cidade", false, DataSourceUpdateMode.OnPropertyChanged);
            txtComplemento.DataBindings.Add
                ("Text", Modelo, "Comp_cliente", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUF.DataBindings.Add
                ("Text", Modelo, "CepSelecionado.Uf", false, DataSourceUpdateMode.OnPropertyChanged);
            txtLogradouro.DataBindings.Add
                ("Text", Modelo, "CepSelecionado.Logra", false, DataSourceUpdateMode.OnPropertyChanged);
            txtNumero.DataBindings.Add
                ("Text", Modelo, "Num_cliente", false, DataSourceUpdateMode.OnPropertyChanged);
            txtRG.DataBindings.Add
                ("Text", Modelo, "Rg_cliente", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Modelo.Nome_cliente))
            {
                errorProvider1.SetError(lblNome, "Nome em branco inválido");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lblNome, null);
                e.Cancel = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (Modelo.Cod_cliente > 0)
                {
                    clienteBanco.AlterarCliente(Modelo);
                    MessageBox.Show("Cliente alterado com sucesso, código: " + Modelo.Cod_cliente);
                }
                else
                {
                    clienteBanco.InserirCliente(Modelo);
                    MessageBox.Show("Cliente criado com sucesso, código: " + Modelo.Cod_cliente);
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void ConverterMascara(object sender, ConvertEventArgs e)
        {
            Binding binding = sender as Binding;
            MaskedTextBox maskedTextBox = binding.Control as MaskedTextBox;

            if (!maskedTextBox.MaskFull)
                e.Value = null;
        }

        private void mskCEP_Validating(object sender, CancelEventArgs e)
        {
            if (mskCEP.MaskFull)
            {
                CEP cepRetornado = cepBanco.RetornarCEP(Modelo.CepSelecionado.Cep);
                if (cepRetornado != null)
                {
                    Modelo.CepSelecionado = cepRetornado;
                    errorProvider1.SetError(lblCEP, null);
                    e.Cancel = false;
                }
                else
                {
                    errorProvider1.SetError(lblCEP, "CEP não encontrado");
                    e.Cancel = true;
                }
            }
            else
            {
                Modelo.CepSelecionado = null;
                errorProvider1.SetError(lblCEP, null);
                e.Cancel = false;
            }
        }

        private void mskCPF_Validating(object sender, CancelEventArgs e)
        {
            if(mskCPF.MaskFull)
            {
                if (Validacoes.Validacoes.ValidarCPF(Modelo.Cpf_cliente))
                {
                    if (clienteBanco.ContadorCPF(Modelo) > 0)
                    {
                        errorProvider1.SetError(lblCPF, "CPF já cadastrado no banco de dados");
                        e.Cancel = true;
                    }
                    else
                    {
                        errorProvider1.SetError(lblCPF, null);
                        e.Cancel = false;
                    }
                }
                else
                {
                    errorProvider1.SetError(lblCPF,"CPF Inválido");
                    e.Cancel = true;
                }
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
            Binding();
        }
    }
}
