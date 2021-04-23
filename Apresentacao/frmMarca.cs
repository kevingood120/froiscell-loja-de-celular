using Apresentacao.Validacoes;
using MetroFramework.Forms;
using Modelo;
using MySql;
using System;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmMarca : MetroForm
    {
        MarcaBanco marcaBanco = new MarcaBanco();
        MarcaColecao Colecao { get; set; }
        public frmMarca()
        {
            InitializeComponent();
            Colecao = marcaBanco.MostrarTodos();
            dgvMarcas.DataSource = Colecao;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Colecao.AddNew();
        }

        private void dgvMarcas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                if(ValidateChildren(ValidationConstraints.Enabled))
                {
                    Marca marcaSelecionada = dgvMarcas.Rows[e.RowIndex].DataBoundItem as Marca;
                    if (marcaSelecionada.Cod_marca > 0)
                        marcaBanco.AlterarMarca(marcaSelecionada);
                    else
                        marcaBanco.InserirMarca(marcaSelecionada);
                }              
            }

        }

        private void dgvMarcas_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Marca marcaSelecionada = dgvMarcas.Rows[e.RowIndex].DataBoundItem as Marca;
                if (string.IsNullOrWhiteSpace(marcaSelecionada.Nome_marca))
                {
                    dgvMarcas.Rows[e.RowIndex].ErrorText = "Marca em branco inválido";
                    e.Cancel = true;
                }
                else if (marcaBanco.ContadorMarca(marcaSelecionada) > 0)
                {
                    dgvMarcas.Rows[e.RowIndex].ErrorText = "Marca já cadastrada no sistema";
                    e.Cancel = true;
                }
                else
                {
                    dgvMarcas.Rows[e.RowIndex].ErrorText = null;
                    e.Cancel = false;
                }
            }
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }
    }
}
