namespace Apresentacao
{
    partial class frmCEP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblLogradouro = new MetroFramework.Controls.MetroLabel();
            this.lblCidade = new MetroFramework.Controls.MetroLabel();
            this.lblBairro = new MetroFramework.Controls.MetroLabel();
            this.lblCep = new MetroFramework.Controls.MetroLabel();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUF = new MetroFramework.Controls.MetroTextBox();
            this.txtLogradouro = new MetroFramework.Controls.MetroTextBox();
            this.txtCidade = new MetroFramework.Controls.MetroTextBox();
            this.lblUF = new MetroFramework.Controls.MetroLabel();
            this.txtBairro = new MetroFramework.Controls.MetroTextBox();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(6, 61);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(79, 19);
            this.lblLogradouro.TabIndex = 0;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(202, 16);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(51, 19);
            this.lblCidade.TabIndex = 1;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(82, 16);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(45, 19);
            this.lblBairro.TabIndex = 2;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(6, 16);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(33, 19);
            this.lblCep.TabIndex = 4;
            this.lblCep.Text = "CEP";
            // 
            // mskCEP
            // 
            this.mskCEP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCEP.Location = new System.Drawing.Point(6, 38);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(70, 23);
            this.mskCEP.TabIndex = 1;
            this.mskCEP.Validating += new System.ComponentModel.CancelEventHandler(this.mskCEP_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUF);
            this.groupBox1.Controls.Add(this.txtLogradouro);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.lblUF);
            this.groupBox1.Controls.Add(this.lblCep);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.mskCEP);
            this.groupBox1.Controls.Add(this.lblLogradouro);
            this.groupBox1.Controls.Add(this.lblCidade);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Location = new System.Drawing.Point(8, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtUF
            // 
            this.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtUF.CustomButton.Image = null;
            this.txtUF.CustomButton.Location = new System.Drawing.Point(35, 1);
            this.txtUF.CustomButton.Name = "";
            this.txtUF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUF.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtUF.CustomButton.TabIndex = 1;
            this.txtUF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUF.CustomButton.UseSelectable = true;
            this.txtUF.CustomButton.Visible = false;
            this.txtUF.Lines = new string[] {
        "SP"};
            this.txtUF.Location = new System.Drawing.Point(238, 83);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.PasswordChar = '\0';
            this.txtUF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUF.SelectedText = "";
            this.txtUF.SelectionLength = 0;
            this.txtUF.SelectionStart = 0;
            this.txtUF.ShortcutsEnabled = true;
            this.txtUF.Size = new System.Drawing.Size(57, 23);
            this.txtUF.TabIndex = 5;
            this.txtUF.Text = "SP";
            this.txtUF.UseSelectable = true;
            this.txtUF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUF.Validating += new System.ComponentModel.CancelEventHandler(this.txtUF_Validating);
            // 
            // txtLogradouro
            // 
            // 
            // 
            // 
            this.txtLogradouro.CustomButton.Image = null;
            this.txtLogradouro.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.txtLogradouro.CustomButton.Name = "";
            this.txtLogradouro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLogradouro.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtLogradouro.CustomButton.TabIndex = 1;
            this.txtLogradouro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLogradouro.CustomButton.UseSelectable = true;
            this.txtLogradouro.CustomButton.Visible = false;
            this.txtLogradouro.Lines = new string[0];
            this.txtLogradouro.Location = new System.Drawing.Point(6, 83);
            this.txtLogradouro.MaxLength = 32767;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.PasswordChar = '\0';
            this.txtLogradouro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLogradouro.SelectedText = "";
            this.txtLogradouro.SelectionLength = 0;
            this.txtLogradouro.SelectionStart = 0;
            this.txtLogradouro.ShortcutsEnabled = true;
            this.txtLogradouro.Size = new System.Drawing.Size(226, 23);
            this.txtLogradouro.TabIndex = 4;
            this.txtLogradouro.UseSelectable = true;
            this.txtLogradouro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLogradouro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLogradouro.Validating += new System.ComponentModel.CancelEventHandler(this.txtLogradouro_Validating);
            // 
            // txtCidade
            // 
            // 
            // 
            // 
            this.txtCidade.CustomButton.Image = null;
            this.txtCidade.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txtCidade.CustomButton.Name = "";
            this.txtCidade.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCidade.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtCidade.CustomButton.TabIndex = 1;
            this.txtCidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCidade.CustomButton.UseSelectable = true;
            this.txtCidade.CustomButton.Visible = false;
            this.txtCidade.Lines = new string[0];
            this.txtCidade.Location = new System.Drawing.Point(202, 38);
            this.txtCidade.MaxLength = 32767;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCidade.SelectedText = "";
            this.txtCidade.SelectionLength = 0;
            this.txtCidade.SelectionStart = 0;
            this.txtCidade.ShortcutsEnabled = true;
            this.txtCidade.Size = new System.Drawing.Size(94, 23);
            this.txtCidade.TabIndex = 3;
            this.txtCidade.UseSelectable = true;
            this.txtCidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCidade.Validating += new System.ComponentModel.CancelEventHandler(this.txtCidade_Validating);
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(238, 64);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(25, 19);
            this.lblUF.TabIndex = 5;
            this.lblUF.Text = "UF";
            // 
            // txtBairro
            // 
            // 
            // 
            // 
            this.txtBairro.CustomButton.Image = null;
            this.txtBairro.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtBairro.CustomButton.Name = "";
            this.txtBairro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBairro.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtBairro.CustomButton.TabIndex = 1;
            this.txtBairro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBairro.CustomButton.UseSelectable = true;
            this.txtBairro.CustomButton.Visible = false;
            this.txtBairro.Lines = new string[0];
            this.txtBairro.Location = new System.Drawing.Point(82, 38);
            this.txtBairro.MaxLength = 32767;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.ShortcutsEnabled = true;
            this.txtBairro.Size = new System.Drawing.Size(114, 23);
            this.txtBairro.TabIndex = 2;
            this.txtBairro.UseSelectable = true;
            this.txtBairro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBairro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBairro.Validating += new System.ComponentModel.CancelEventHandler(this.txtBairro_Validating);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(153, 185);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseSelectable = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.CausesValidation = false;
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVoltar.Location = new System.Drawing.Point(234, 185);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseSelectable = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // frmCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 224);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCEP";
            this.Resizable = false;
            this.Text = "CEP";
            this.Load += new System.EventHandler(this.frmCEP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblLogradouro;
        private MetroFramework.Controls.MetroLabel lblCidade;
        private MetroFramework.Controls.MetroLabel lblBairro;
        private MetroFramework.Controls.MetroLabel lblCep;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtLogradouro;
        private MetroFramework.Controls.MetroTextBox txtCidade;
        private MetroFramework.Controls.MetroTextBox txtBairro;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroTextBox txtUF;
        private MetroFramework.Controls.MetroLabel lblUF;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}