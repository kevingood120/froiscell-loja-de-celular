using Apresentacao.Validacoes;
using MetroFramework.Forms;
using Modelo;
using Modelo.Enums;
using MySql;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmAparelho : MetroForm
    {
        MarcaBanco marcaBanco = new MarcaBanco();
        AparelhoBanco aparelhoBanco = new AparelhoBanco();
        Aparelho Modelo { get; set; }
        public frmAparelho(Aparelho aparelho)
        {
            InitializeComponent();
            Modelo = aparelho;
            ComboMarcaConfig();
            ComboAparelhoConfig();
        }

        public void ComboAparelhoConfig()
        {
            var listaAparelhos = from Aparelhos aparelho in Enum.GetValues(typeof(Aparelhos))
                                 select new { Key = aparelho, Value = Convert.ToString(aparelho) };
            cboAparelho.ValueMember = "Key";
            cboAparelho.DisplayMember = "Value";
            cboAparelho.DataSource = listaAparelhos.ToList();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmMarca marca = new frmMarca();
            marca.ShowDialog();
            cboMarcas.DataSource = marcaBanco.MostrarTodos();
            marca.Dispose();
        }

        private void ComboMarcaConfig()
        {
            cboMarcas.DisplayMember = "Nome_marca";
            cboMarcas.ValueMember = "Cod_marca";
            cboMarcas.DataSource = marcaBanco.MostrarTodos();
        }

        private void Binding()
        {
            cboMarcas.DataBindings.Add("SelectedValue", Modelo, "MarcaSelecionada.Cod_marca", false, DataSourceUpdateMode.OnPropertyChanged);
            cboAparelho.DataBindings.Add("SelectedValue", Modelo, "TipoSelecionado", false, DataSourceUpdateMode.OnPropertyChanged);
            txtModelo.DataBindings.Add("Text", Modelo, "Modelo_aparelho", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                if(Modelo.Cod_aparelho > 0)
                {
                    aparelhoBanco.AlterarAparelho(Modelo);
                    MessageBox.Show("Aparelho alterado com sucesso, código: " + Modelo.Cod_aparelho);
                }
                else
                {
                    aparelhoBanco.InserirAparelho(Modelo);
                    MessageBox.Show("Aparelho inserido com sucesso, código: " + Modelo.Cod_aparelho);
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void txtModelo_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Modelo.Modelo_aparelho))
            {
                errorProvider1.SetError(lblModelo, "Modelo em branco inválido");
                e.Cancel = true;
            }
            else if(aparelhoBanco.ContadorAparelho(Modelo) > 0)
            {
                errorProvider1.SetError(lblModelo, "Modelo já cadastrado no sistema");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lblModelo, null);
                e.Cancel = false;
            }
        }

        private void frmAparelho_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
            Binding();
        }

        private void cboMarcas_Validating(object sender, CancelEventArgs e)
        {
            if(cboMarcas.SelectedIndex < 0)
            {
                errorProvider1.SetError(lblMarca, "Selecione uma marca");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lblMarca, null);
                e.Cancel = false;
            }
        }
    }
}
