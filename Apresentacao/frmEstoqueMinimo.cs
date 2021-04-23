using Apresentacao.Validacoes;
using MetroFramework.Forms;
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
    public partial class frmEstoqueMinimo : MetroForm
    {
        public frmEstoqueMinimo()
        {
            InitializeComponent();
            ProdutoBanco produtoBanco = new ProdutoBanco();
            ProdutoBindingSource.DataSource = produtoBanco.RelatorioEstoqueMinimo();
        }

        private void frmEstoqueMinimo_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
            reportEstoque.RefreshReport();
        }
    }
}
