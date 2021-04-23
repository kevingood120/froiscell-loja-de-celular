using Apresentacao.Validacoes;
using MetroFramework.Forms;
using Modelo;
using MySql;
using System;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmCor : MetroForm
    {
        CorBanco corBanco = new CorBanco();
        CorColecao Colecao { get; set; }
        public frmCor()
        {
            InitializeComponent();
            Colecao = corBanco.MostrarTodos();
            dgvCores.DataSource = Colecao;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Colecao.AddNew();
        }

        private void dgvCores_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if(ValidateChildren(ValidationConstraints.Enabled))
                {
                    Cor corSelecionada = dgvCores.Rows[e.RowIndex].DataBoundItem as Cor;
                    if (corSelecionada.Cod_cor > 0)
                        corBanco.AlterarCor(corSelecionada);
                    else
                        corBanco.InserirCor(corSelecionada);
                }
            }
        }

        private void dgvCores_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Cor corSelecionada = dgvCores.Rows[e.RowIndex].DataBoundItem as Cor;
                if (string.IsNullOrWhiteSpace(corSelecionada.Nome_cor))
                {
                    dgvCores.Rows[e.RowIndex].ErrorText = "Cor em branco inválida";
                    e.Cancel = true;
                }
                else if (corBanco.ContadorCores(corSelecionada) > 0)
                {
                    dgvCores.Rows[e.RowIndex].ErrorText = "Cor já existente no banco de dados";
                    e.Cancel = true;
                }
                else
                {
                    dgvCores.Rows[e.RowIndex].ErrorText = null;
                    e.Cancel = false;
                }
            }
        }

        private void frmCor_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }
    }
}
