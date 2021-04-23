using Apresentacao.Validacoes;
using MetroFramework.Forms;
using Modelo;
using MySql;
using System;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmProcurarCliente : MetroForm
    {
        ClienteBanco clienteBanco = new ClienteBanco();
        public frmProcurarCliente()
        {
            InitializeComponent();
        }

        public Cliente ClienteSelecionado { get; set; }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente(new Cliente());
            frmCliente.ShowDialog();
            frmCliente.Dispose();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                ClienteSelecionado = dgvClientes.CurrentRow.DataBoundItem as Cliente;
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Selecione um cliente");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        public void Pesquisar()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
                dgvClientes.DataSource = null;
            else
                dgvClientes.DataSource = clienteBanco.PesquisarCliente(txtNome.Text);
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Pesquisar();
        }

        private void frmProcurarCliente_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }
    }
}
