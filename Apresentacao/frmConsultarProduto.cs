using Apresentacao.Validacoes;
using MetroFramework.Forms;
using Modelo;
using MySql;
using System;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmConsultarProduto : MetroForm
    {
        ProdutoBanco produtoBanco = new ProdutoBanco();

        public frmConsultarProduto()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmProduto produto = new frmProduto(new Modelo.Produto());
            produto.ShowDialog();
            produto.Dispose();
        }

        private void dgvProdutos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                Produto produtoSelecionado = dgvProdutos.Rows[e.RowIndex].DataBoundItem as Produto;
                frmProduto produto = new frmProduto(produtoSelecionado);
                produto.ShowDialog();
                produto.Dispose();
            }
        }

        private void btnEstoqueMinimo_Click(object sender, EventArgs e)
        {
            frmEstoqueMinimo minimo = new frmEstoqueMinimo();
            minimo.ShowDialog();
            minimo.Dispose();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = string.IsNullOrWhiteSpace(txtProduto.Text) ? null : produtoBanco.PesquisarPorNome(txtProduto.Text);
        }

        private void txtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                dgvProdutos.DataSource = string.IsNullOrWhiteSpace(txtProduto.Text) ? null : produtoBanco.PesquisarPorNome(txtProduto.Text);
        }

        private void frmConsultarProduto_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }
    }
}
