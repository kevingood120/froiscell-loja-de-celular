using Apresentacao.Validacoes;
using MetroFramework.Forms;
using Modelo;
using MySql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmCodigoBarras : MetroForm
    {
        public Produto ProdutoSelecionado { get; set; }

        ProdutoBanco produtoBanco = new ProdutoBanco();
        public frmCodigoBarras()
        {
            InitializeComponent();
            txtCodigoBarras.Focus();
        }

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(!string.IsNullOrWhiteSpace(txtCodigoBarras.Text))
                {
                    ProdutoSelecionado = produtoBanco.PegarProdutoCodigoBarras(txtCodigoBarras.Text);
                    if (ProdutoSelecionado == null)
                    {
                        MessageBox.Show("Produto não encontrado com o seguinte código de barras: " + txtCodigoBarras.Text);
                        txtCodigoBarras.Focus();
                    }
                    else
                        DialogResult = DialogResult.OK;
                }
            }
        }

        private void frmCodigoBarras_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }
    }
}
