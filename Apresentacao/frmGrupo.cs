using Apresentacao.Validacoes;
using MetroFramework.Forms;
using Modelo;
using MySql;
using System;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmGrupo : MetroForm
    {
        GrupoBanco bancoGrupo = new GrupoBanco();
        GrupoColecao Colecao { get; set; }
        public frmGrupo()
        {
            InitializeComponent();
            Colecao = bancoGrupo.MostrarTodos();
            dgvGrupo.DataSource = Colecao;
        }

        private void dgvGrupo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    Grupo grupoSelecionado = dgvGrupo.Rows[e.RowIndex].DataBoundItem as Grupo;
                    if (grupoSelecionado.Cod_grupo > 0)
                        bancoGrupo.AlterarGrupo(grupoSelecionado);
                    else
                        bancoGrupo.InserirGrupo(grupoSelecionado);
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Colecao.AddNew();
        }

        private void dgvGrupo_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Grupo grupoSelecionado = dgvGrupo.Rows[e.RowIndex].DataBoundItem as Grupo;
                if (string.IsNullOrWhiteSpace(grupoSelecionado.Nome_grupo))
                {
                    dgvGrupo.Rows[e.RowIndex].ErrorText = "Grupo em branco inválido";
                    e.Cancel = true;
                }
                else if (bancoGrupo.ContadorGrupo(grupoSelecionado) > 0)
                {
                    dgvGrupo.Rows[e.RowIndex].ErrorText = "Grupo já existente no banco de dados";
                    e.Cancel = true;
                }
                else
                {
                    dgvGrupo.Rows[e.RowIndex].ErrorText = null;
                    e.Cancel = false;
                }
            }
        }

        private void frmGrupo_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }
    }
}
