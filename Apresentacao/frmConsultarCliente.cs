using Apresentacao.Validacoes;
using MetroFramework.Forms;
using Modelo;
using MySql;
using System;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmConsultarCliente : MetroForm
    {
        ClienteBanco clienteBanco = new ClienteBanco();
        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            Cliente novoCliente = new Cliente();
            frmCliente cliente = new frmCliente(novoCliente);
            if (cliente.ShowDialog() == DialogResult.OK)
                dgvCliente.DataSource = new ClienteColecao()
                {
                    clienteBanco.PesquisarPorCodigo(novoCliente.Cod_cliente)
                };
            cliente.Dispose();
        }

        private void dgvCliente_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCliente.CurrentRow != null)
            {
                Cliente clienteSelecionado = dgvCliente.CurrentRow.DataBoundItem as Cliente;
                frmCliente frmCliente = new frmCliente(clienteSelecionado);
                if(frmCliente.ShowDialog() == DialogResult.OK)
                    dgvCliente.DataSource = new ClienteColecao()
                    {
                        clienteBanco.PesquisarPorCodigo(clienteSelecionado.Cod_cliente)
                    };
                frmCliente.Dispose();
            }
            else
                MessageBox.Show("Selecione um cliente");
        }

        private void btnOS_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow == null)
                MessageBox.Show("Selecione um cliente para criar uma OS");
            else
            {
                frmOS oS = new frmOS(new OS()
                {
                    ClienteSelecionado = dgvCliente.CurrentRow.DataBoundItem as Cliente
                });
                oS.ShowDialog();
                oS.Dispose();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvCliente.DataSource = string.IsNullOrWhiteSpace(txtNome.Text) ? null : clienteBanco.PesquisarPorNome(txtNome.Text);
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                dgvCliente.DataSource = string.IsNullOrWhiteSpace(txtNome.Text) ? null : clienteBanco.PesquisarPorNome(txtNome.Text);
        }

        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }
    }
}
