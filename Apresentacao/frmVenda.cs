using Apresentacao.Cupons;
using Apresentacao.Validacoes;
using MetroFramework.Forms;
using Modelo;
using MySql;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmVenda : MetroForm
    {
        Venda Modelo { get; set; }
        VendaBanco vendaBanco = new VendaBanco();
        public frmVenda(Venda venda)
        {
            InitializeComponent();
            Modelo = venda;
        }

        private void Binding()
        {
            txtCliente.DataBindings.Add("Text", Modelo, "ClienteSelecionado.Nome_cliente", false, DataSourceUpdateMode.OnPropertyChanged);
            txtObservacao.DataBindings.Add("Text", Modelo, "Obs_venda", false, DataSourceUpdateMode.OnPropertyChanged);
            dgvCarrinho.DataBindings.Add("DataSource", Modelo, "Itens", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTotal.DataBindings.Add("Numero", Modelo, "Total_venda", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
            Binding();
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
                errorProvider1.SetError(lblCliente, "Cliente não informado");
            frmProcurarCliente.Dispose();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdicionarItemCarrinho frmAdicionarItemCarrinho = new frmAdicionarItemCarrinho();
            if (frmAdicionarItemCarrinho.ShowDialog() == DialogResult.OK)
            {
                if (!Modelo.Itens.Any(p => p.ProdutoSelecionado.Cod_produto == frmAdicionarItemCarrinho.ItemSelecionado.ProdutoSelecionado.Cod_produto))
                {
                    Modelo.Itens.Add(frmAdicionarItemCarrinho.ItemSelecionado);
                    Modelo.Total_venda = Modelo.Total_venda + frmAdicionarItemCarrinho.ItemSelecionado.Subtotal;
                }
                else
                    MessageBox.Show("Item já existente no carrinho");
            }
            frmAdicionarItemCarrinho.Dispose();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvCarrinho.CurrentRow != null)
            {
                ItemVenda item = dgvCarrinho.CurrentRow.DataBoundItem as ItemVenda;
                Modelo.Total_venda = Modelo.Total_venda - item.ProdutoSelecionado.Preco_produto;
                item.Subtotal = item.Subtotal - item.ProdutoSelecionado.Preco_produto;
                if (item.Quantidade > 1)
                    item.Quantidade = Convert.ToInt16(item.Quantidade - 1);
                else
                    Modelo.Itens.Remove(item);
            }
            else
                MessageBox.Show("Selecione um item para remover na lista");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (Modelo.Itens.Count > 0)
                {
                    frmFinalizarItem frmFinalizarItem = new frmFinalizarItem(Modelo);
                    if (frmFinalizarItem.ShowDialog() == DialogResult.OK)
                    {
                        vendaBanco.InserirVenda(Modelo);
                        if (frmFinalizarItem.Cupom)
                            new CupomVenda(Modelo.Cod_venda).Print();
                        frmFinalizarItem.Dispose();
                        MessageBox.Show("Venda registrada com sucesso");
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                    MessageBox.Show("Venda sem itens inválida");
            }
        }

        private void txtCliente_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Modelo.ClienteSelecionado.Nome_cliente) || Modelo.ClienteSelecionado.Cod_cliente == 0)
            {
                errorProvider1.SetError(lblCliente, "Cliente não informado");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lblCliente, null);
                e.Cancel = false;
            }
        }

        private void btnCodigoBarras_Click(object sender, EventArgs e)
        {

            frmCodigoBarras codigobarras = new frmCodigoBarras();
            while(codigobarras.ShowDialog() == DialogResult.OK)
            {
                Produto produtoSelecionado = codigobarras.ProdutoSelecionado;
                ItemVenda itemExistente = Modelo.Itens.FirstOrDefault(p => p.ProdutoSelecionado.Cod_produto == produtoSelecionado.Cod_produto);
                if (itemExistente != null)
                {
                    var quantidadeVendida = itemExistente.Quantidade + 1;
                    if (produtoSelecionado.Qtd_produto >= quantidadeVendida)
                    {
                        itemExistente.Quantidade = Convert.ToInt16(quantidadeVendida);
                        itemExistente.Subtotal = itemExistente.Subtotal + itemExistente.ProdutoSelecionado.Preco_produto;
                        Modelo.Total_venda = Modelo.Total_venda + itemExistente.ProdutoSelecionado.Preco_produto;
                    }
                    else
                        MessageBox.Show("Estoque insuficiente");
                }
                else
                {
                    if (produtoSelecionado.Qtd_produto >= 1)
                    {
                        ItemVenda item = new ItemVenda();
                        item.ProdutoSelecionado = produtoSelecionado;
                        item.Quantidade = 1;
                        item.Subtotal = produtoSelecionado.Preco_produto;
                        Modelo.Total_venda = Modelo.Total_venda + produtoSelecionado.Preco_produto;
                        Modelo.Itens.Add(item);
                    }
                    else
                        MessageBox.Show("Estoque insuficiente");
                }
                codigobarras = new frmCodigoBarras();
            }
        }
    }
}
