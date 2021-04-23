using Apresentacao.Validacoes;
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
    public partial class frmAdicionarDinheiroCaixa : MetroFramework.Forms.MetroForm
    {
        MovimentacaoCaixa movimentacaoCaixa;
        MovimentacaoCaixaBanco movimentacaoCaixaBanco = new MovimentacaoCaixaBanco();
        public frmAdicionarDinheiroCaixa()
        {
            InitializeComponent();
            Bindings();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                var dialogResult = MessageBox.Show("Você deseja continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    movimentacaoCaixaBanco.Adicionar(movimentacaoCaixa);
                    MessageBox.Show($"ID gerado: {movimentacaoCaixa.Cod_mov}");
                    Close();
                }
            }
        }

        private void Bindings()
        {
            movimentacaoCaixa = new MovimentacaoCaixa();
            txtRazao.DataBindings.Add("Text", movimentacaoCaixa, "Razao", false, DataSourceUpdateMode.OnPropertyChanged);
            txtValor.DataBindings.Add("Numero", movimentacaoCaixa, "Valor", false, DataSourceUpdateMode.OnPropertyChanged);
            chkSubtrair.DataBindings.Add("Checked", movimentacaoCaixa, "Subtrair", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void frmAdicionarDinheiroCaixa_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }

        private void txtValor_Validating(object sender, CancelEventArgs e)
        {
            if(movimentacaoCaixa.Valor <= decimal.Zero)
            {
                errorProvider1.SetError(lblValor, "Campo tem que ser maior que 0");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lblValor, null);
                e.Cancel = false;
            }
        }

        private void txtRazao_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(movimentacaoCaixa.Razao))
            {
                errorProvider1.SetError(lblRazao, "Campo obrigatório");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lblRazao, null);
                e.Cancel = false;
            }
        }
    }
}
