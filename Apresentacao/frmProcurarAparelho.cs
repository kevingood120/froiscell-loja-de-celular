using Apresentacao.Validacoes;
using MetroFramework.Forms;
using Modelo;
using MySql;
using System;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmProcurarAparelho : MetroForm
    {
        AparelhoBanco aparelhoBanco = new AparelhoBanco();
        public frmProcurarAparelho()
        {
            InitializeComponent();
        }

        public Aparelho AparelhoSelecionado { get; set; }

        private void btnNovoAparelho_Click(object sender, EventArgs e)
        {
            frmAparelho frmAparelho = new frmAparelho(new Aparelho());
            frmAparelho.ShowDialog();
            frmAparelho.Dispose();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvAparelhos.CurrentRow != null)
            {
                AparelhoSelecionado = dgvAparelhos.CurrentRow.DataBoundItem as Aparelho;
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Selecione um aparelho");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        public void Pesquisar()
        {
            if (string.IsNullOrWhiteSpace(txtAparelho.Text))
                dgvAparelhos.DataSource = null;
            else
                dgvAparelhos.DataSource = aparelhoBanco.PesquisarPorNome(txtAparelho.Text);
        }

        private void txtAparelho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Pesquisar();
        }

        private void frmProcurarAparelho_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }
    }
}
