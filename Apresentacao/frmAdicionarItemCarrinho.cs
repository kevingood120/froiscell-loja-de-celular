using Apresentacao.Validacoes;
using MetroFramework.Forms;
using Modelo;
using MySql;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmAdicionarItemCarrinho : MetroForm, INotifyPropertyChanged
    {
        ItemVenda itemSelecionado;
        ProdutoBanco produtoBanco = new ProdutoBanco();
        public event PropertyChangedEventHandler PropertyChanged;

        public frmAdicionarItemCarrinho()
        {
            InitializeComponent();
            ItemSelecionado.Quantidade = 1;
            Binding();
        }

        public ItemVenda ItemSelecionado
        {
            get
            {
                if (itemSelecionado == null)
                    itemSelecionado = new ItemVenda();
                return itemSelecionado;
            }
            set
            {
                itemSelecionado = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemSelecionado"));
            }
        }

        private void Binding()
        {
            numericQuantidade.DataBindings.Add("Value", this, "ItemSelecionado.Quantidade", false, DataSourceUpdateMode.OnPropertyChanged);        
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if(dgvProdutos.CurrentRow != null)
            {
                ItemSelecionado.ProdutoSelecionado = dgvProdutos.CurrentRow.DataBoundItem as Produto;
                if (ItemSelecionado.ProdutoSelecionado.Qtd_produto >= ItemSelecionado.Quantidade)
                {
                    ItemSelecionado.Subtotal = ItemSelecionado.ProdutoSelecionado.Preco_produto * ItemSelecionado.Quantidade;
                    DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("No estoque não contém essa quantidade de itens");
            }
            else
                MessageBox.Show("Selecione um produto para adicionar um item no carrinho");
        }

        private void btnNovoAparelho_Click(object sender, EventArgs e)
        {
            frmProduto produto = new frmProduto(new Produto());
            produto.ShowDialog();
            produto.Dispose();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void txtProdutoGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Pesquisar();
        }

        public void Pesquisar()
        {
            if (string.IsNullOrWhiteSpace(txtProdutoGrupo.Text))
                dgvProdutos.DataSource = null;
            else
                dgvProdutos.DataSource = produtoBanco.PesquisarPorNome(txtProdutoGrupo.Text);
        }

        private void numericQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Pesquisar();
        }

        private void frmAdicionarItemCarrinho_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }
    }
}
