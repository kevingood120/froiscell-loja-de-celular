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
    public partial class frmConsultarCEP : MetroForm
    {
        CEPBanco cEPBanco = new CEPBanco();
        public frmConsultarCEP()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCEP cep = new frmCEP(new Modelo.CEP());
            cep.ShowDialog();
            cep.Dispose();
        }

        private void dgvCEP_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                CEP cepSelecionado = dgvCEP.Rows[e.RowIndex].DataBoundItem as CEP;
                frmCEP cep = new frmCEP(cepSelecionado);
                cep.ShowDialog();
                cep.Dispose();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvCEP.DataSource = string.IsNullOrWhiteSpace(txtLogradouro.Text) ? null : cEPBanco.PesquisarPorLogradouro(txtLogradouro.Text);
        }

        private void txtLogradouro_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                dgvCEP.DataSource = string.IsNullOrWhiteSpace(txtLogradouro.Text) ? null : cEPBanco.PesquisarPorLogradouro(txtLogradouro.Text);
        }

        private void frmConsultarCEP_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }
    }
}
