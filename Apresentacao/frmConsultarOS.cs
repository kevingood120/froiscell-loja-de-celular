using Apresentacao.Validacoes;
using MetroFramework.Forms;
using Modelo;
using MySql;
using System;
using System.Linq;
using System.Windows.Forms;
using Modelo.Enums;

namespace Apresentacao
{
    public partial class frmConsultarOS : MetroForm
    {
        OSBanco oSBanco = new OSBanco();
        ClienteBanco clienteBanco = new ClienteBanco();
        public frmConsultarOS()
        {
            InitializeComponent();
            ComboBoxStatusConfig();
        }

        private void btnNovoOS_Click(object sender, EventArgs e)
        {
            frmOS frmOS = new frmOS(new OS());
            frmOS.ShowDialog();
            frmOS.Dispose();
        }

        public void ComboBoxStatusConfig()
        {
            var meusStatus = from Status valor in Enum.GetValues(typeof(Status))
                             select new { Key = valor, Value = Validacoes.Validacoes.GetEnumDescription(valor) };
            cboStatus.DisplayMember = "Value";
            cboStatus.ValueMember = "Key";
            cboStatus.DataSource = meusStatus.ToList();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        public void Pesquisar()
        {
            if (chkStatus.Checked)
            {
                Status status = (Status)cboStatus.SelectedValue;
                dgvOS.DataSource = oSBanco.PesquisarPorClienteStatus(txtNome.Text, status);
            }
            else
            {
                uint codigo = 0;
                if (uint.TryParse(txtNome.Text, out codigo))
                {
                    OS ordemPesquisa = oSBanco.PesquisarPorCodigo(codigo);
                    if (ordemPesquisa != null)
                    {
                        frmOS os = new frmOS(ordemPesquisa);
                        os.ShowDialog();
                    }
                    else
                        MessageBox.Show("OS não encontrada, código da os: " + codigo);
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtNome.Text))
                        MessageBox.Show("Nome ou código em branco inválido");
                    else
                        dgvOS.DataSource = oSBanco.PesquisarPorCliente(txtNome.Text);
                }
            }
        }

        private void dgvOS_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OS osSelecionada = dgvOS.CurrentRow.DataBoundItem as OS;
            frmOS os = new frmOS(osSelecionada);
            if(os.ShowDialog() == DialogResult.OK)
            {
                dgvOS.DataSource = new OSColecao()
                {
                    oSBanco.PesquisarPorCodigo(osSelecionada.Cod_ordem)
                };
            }
            os.Dispose();
        }

        private void btnNovaOSExistente_Click(object sender, EventArgs e)
        {
            if (dgvOS.CurrentRow != null)
            {
                OS osSelecionada = dgvOS.CurrentRow.DataBoundItem as OS;
                OS novoOS = new OS();
                novoOS.AparelhoSelecionado = osSelecionada.AparelhoSelecionado;
                novoOS.ClienteSelecionado = osSelecionada.ClienteSelecionado;
                novoOS.CorSelecionada = osSelecionada.CorSelecionada;
                novoOS.Imei1_aparelho = osSelecionada.Imei1_aparelho;
                novoOS.Imei2_aparelho = osSelecionada.Imei2_aparelho;
                frmOS frmOS = new frmOS(novoOS);
                if (frmOS.ShowDialog() == DialogResult.OK)
                    dgvOS.DataSource = new OSColecao()
                    {
                        oSBanco.PesquisarPorCodigo(novoOS.Cod_ordem)
                    };
            }
            else
                MessageBox.Show("Selecione uma linha para abrir uma nova OS com os mesmos dados");
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Pesquisar();
        }

        private void frmConsultarOS_Load(object sender, EventArgs e)
        {
            cboStatus.DataBindings.Add("Enabled", chkStatus, "Checked", false, DataSourceUpdateMode.OnPropertyChanged);
            components.SetStyle(this);
        }
    }
}
