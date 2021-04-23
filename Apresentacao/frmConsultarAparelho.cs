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
    public partial class frmConsultarAparelho : MetroForm
    {
        AparelhoBanco aparelhoBanco = new AparelhoBanco();
        public frmConsultarAparelho()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmAparelho aparelho = new frmAparelho(new Modelo.Aparelho());
            aparelho.ShowDialog();
            aparelho.Dispose();
        }

        private void dgvAparelho_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                Aparelho aparelhoSelecionado = dgvAparelho.Rows[e.RowIndex].DataBoundItem as Aparelho;
                frmAparelho aparelho = new frmAparelho(aparelhoSelecionado);
                aparelho.ShowDialog();
                aparelho.Dispose();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvAparelho.DataSource = string.IsNullOrWhiteSpace(txtAparelho.Text) ? null : aparelhoBanco.PesquisarPorNome(txtAparelho.Text);
        }

        private void txtAparelho_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                dgvAparelho.DataSource = string.IsNullOrWhiteSpace(txtAparelho.Text) ? null : aparelhoBanco.PesquisarPorNome(txtAparelho.Text);
        }

        private void frmConsultarAparelho_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }
    }
}
