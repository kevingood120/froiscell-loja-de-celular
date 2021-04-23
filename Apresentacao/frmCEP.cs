using Apresentacao.Validacoes;
using MetroFramework.Forms;
using Modelo;
using MySql;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmCEP : MetroForm
    {
        CEP Modelo { get; set; }
        CEPBanco cepBanco = new CEPBanco();

        public frmCEP(CEP cep)
        {
            Modelo = cep;
            InitializeComponent();
        }
        
        public void Binding()
        {
            txtBairro.DataBindings.Add("Text", Modelo, "Bairro", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCidade.DataBindings.Add("Text", Modelo, "Cidade", false, DataSourceUpdateMode.OnPropertyChanged);
            txtLogradouro.DataBindings.Add("Text", Modelo, "Logra", false, DataSourceUpdateMode.OnPropertyChanged);
            mskCEP.DataBindings.Add("Text", Modelo, "Cep", true, DataSourceUpdateMode.OnPropertyChanged);
            txtUF.DataBindings.Add("Text", Modelo, "Uf", false, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                if(Modelo.Cod_cep > 0)
                {
                    cepBanco.AlterarCEP(Modelo);
                    MessageBox.Show("CEP Alterado com sucesso, código: " + Modelo.Cod_cep);
                }
                else
                {
                    cepBanco.InserirCEP(Modelo);
                    MessageBox.Show("CEP criado com sucesso, código: " + Modelo.Cod_cep);
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void mskCEP_Validating(object sender, CancelEventArgs e)
        {
            if(!mskCEP.MaskFull)
            {
                errorProvider1.SetError(lblCep, "CEP em branco ou faltando caractéres");
                e.Cancel = true;
            }
            else if(cepBanco.ContadorCEP(Modelo) > 0)
            {
                errorProvider1.SetError(lblCep, "CEP já existente no sistema");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lblCep, null);
                e.Cancel = false;
            }
        }

        private void txtBairro_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Modelo.Bairro))
            {
                errorProvider1.SetError(lblBairro, "Bairro em branco inválido");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lblBairro, null);
                e.Cancel = false;
            }
        }

        private void txtCidade_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Modelo.Cidade))
            {
                errorProvider1.SetError(lblCidade, "Cidade em branco inválido");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lblCidade, null);
                e.Cancel = false;
            }
        }

        private void txtLogradouro_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Modelo.Logra))
            {
                errorProvider1.SetError(lblLogradouro, "Logradouro em branco inválido");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lblLogradouro, null);
                e.Cancel = false;
            }
        }

        private void txtUF_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Modelo.Uf))
            {
                errorProvider1.SetError(lblUF, "UF nulo inválido");
                e.Cancel = true;
            }
            else if (Modelo.Uf.Length > 0 && Modelo.Uf.Length < 2)
            {
                errorProvider1.SetError(lblUF, "UF faltando caractéres");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lblUF, null);
                e.Cancel = false;
            }
        }

        private void frmCEP_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
            Binding();
        }
    }
}
