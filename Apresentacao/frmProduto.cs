using Apresentacao.Validacoes;
using MetroFramework.Forms;
using Modelo;
using MySql;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmProduto : MetroForm
    {
        GrupoBanco grupoBanco = new GrupoBanco();
        Produto Modelo { get; set; }
        ProdutoBanco produtoBanco = new ProdutoBanco();


        public frmProduto(Produto produto)
        {
            InitializeComponent();
            Modelo = produto;
            ComboGrupoConfig();
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            frmGrupo grupo = new frmGrupo();
            grupo.ShowDialog();
            cboGrupo.DataSource = grupoBanco.MostrarTodos();
            grupo.Dispose();
        }

        private void ComboGrupoConfig()
        {
            cboGrupo.DisplayMember = "Nome_grupo";
            cboGrupo.ValueMember = "Cod_grupo";
            cboGrupo.DataSource = grupoBanco.MostrarTodos();
        }

        private void Binding()
        {
            cboGrupo.DataBindings.Add("SelectedValue", Modelo, "GrupoSelecionado.Cod_grupo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtValor.DataBindings.Add("Numero", Modelo, "Preco_produto", false, DataSourceUpdateMode.OnPropertyChanged);
            txtValorCusto.DataBindings.Add("Numero", Modelo, "Precocusto_produto", false, DataSourceUpdateMode.OnPropertyChanged);
            numericEstoque.DataBindings.Add("Value", Modelo, "Qtd_produto", false, DataSourceUpdateMode.OnPropertyChanged);
            numericEstoqueMin.DataBindings.Add("Value", Modelo, "Qtdmin_produto", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCodigoBarras.DataBindings.Add("Text", Modelo, "Codigo_barras", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDescricao.DataBindings.Add("Text", Modelo, "Desc_produto", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                if(Modelo.Cod_produto > 0)
                {
                    produtoBanco.AlterarProduto(Modelo);
                    MessageBox.Show("Produto alterado com sucesso, código: " + Modelo.Cod_produto);
                }
                else
                {
                    produtoBanco.AdicionarProduto(Modelo);
                    MessageBox.Show("Produto inserido com sucesso, código: " + Modelo.Cod_produto);
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void txtCodigoBarras_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Modelo.Codigo_barras))
            {
                Modelo.Codigo_barras = null;
                errorProvider1.SetError(lblCodigoBarras, null);
                e.Cancel = false;
            }
            else
            {
                if(produtoBanco.ContadorCodigoBarras(Modelo) > 0)
                {
                    errorProvider1.SetError(lblCodigoBarras, "Codigo de Barras já existente no sistema");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(lblCodigoBarras, null);
                    e.Cancel = false;
                }
            }
        }

        private void txtDescricao_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Modelo.Desc_produto))
            {
                errorProvider1.SetError(lblDescricao, "Descrição em branco inválida");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lblDescricao, null);
                e.Cancel = false;
            }
        }

        private void cboGrupo_Validating(object sender, CancelEventArgs e)
        {
            if(cboGrupo.SelectedIndex < 0)
            {
                errorProvider1.SetError(lblGrupo, "Selecione um grupo");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lblGrupo, null);
                e.Cancel = false;
            }
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
            Binding();
        }

        private void txtValor_Validating(object sender, CancelEventArgs e)
        {
            if(Modelo.Preco_produto == decimal.Zero)
            {
                errorProvider1.SetError(lblValor,"Produto com o preço zero inválido");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lblValor, null);
                e.Cancel = false;
            }
        }
    }
}
