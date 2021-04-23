namespace Apresentacao
{
    partial class frmAdicionarDinheiroCaixa
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
            this.lblValor = new MetroFramework.Controls.MetroLabel();
            this.lblRazao = new MetroFramework.Controls.MetroLabel();
            this.txtRazao = new MetroFramework.Controls.MetroTextBox();
            this.btnAdicionar = new MetroFramework.Controls.MetroLink();
            this.chkSubtrair = new MetroFramework.Controls.MetroCheckBox();
            this.txtValor = new Apresentacao.Controles.CurrencyTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(23, 78);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(38, 19);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor";
            // 
            // lblRazao
            // 
            this.lblRazao.AutoSize = true;
            this.lblRazao.Location = new System.Drawing.Point(23, 126);
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(45, 19);
            this.lblRazao.TabIndex = 3;
            this.lblRazao.Text = "Razão";
            // 
            // txtRazao
            // 
            // 
            // 
            // 
            this.txtRazao.CustomButton.Image = null;
            this.txtRazao.CustomButton.Location = new System.Drawing.Point(416, 2);
            this.txtRazao.CustomButton.Name = "";
            this.txtRazao.CustomButton.Size = new System.Drawing.Size(49, 49);
            this.txtRazao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRazao.CustomButton.TabIndex = 1;
            this.txtRazao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRazao.CustomButton.UseSelectable = true;
            this.txtRazao.CustomButton.Visible = false;
            this.txtRazao.Lines = new string[0];
            this.txtRazao.Location = new System.Drawing.Point(23, 148);
            this.txtRazao.MaxLength = 32767;
            this.txtRazao.Multiline = true;
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.PasswordChar = '\0';
            this.txtRazao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRazao.SelectedText = "";
            this.txtRazao.SelectionLength = 0;
            this.txtRazao.SelectionStart = 0;
            this.txtRazao.ShortcutsEnabled = true;
            this.txtRazao.Size = new System.Drawing.Size(468, 54);
            this.txtRazao.TabIndex = 4;
            this.txtRazao.UseSelectable = true;
            this.txtRazao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRazao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRazao.Validating += new System.ComponentModel.CancelEventHandler(this.txtRazao_Validating);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(416, 271);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseSelectable = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // chkSubtrair
            // 
            this.chkSubtrair.AutoSize = true;
            this.chkSubtrair.Location = new System.Drawing.Point(23, 217);
            this.chkSubtrair.Name = "chkSubtrair";
            this.chkSubtrair.Size = new System.Drawing.Size(116, 15);
            this.chkSubtrair.TabIndex = 6;
            this.chkSubtrair.Text = "Subtrair do caixa?";
            this.chkSubtrair.UseSelectable = true;
            // 
            // txtValor
            // 
            // 
            // 
            // 
            this.txtValor.CustomButton.Image = null;
            this.txtValor.CustomButton.Location = new System.Drawing.Point(446, 1);
            this.txtValor.CustomButton.Name = "";
            this.txtValor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtValor.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtValor.CustomButton.TabIndex = 1;
            this.txtValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValor.CustomButton.UseSelectable = true;
            this.txtValor.CustomButton.Visible = false;
            this.txtValor.Lines = new string[] {
        "R$ 0,00"};
            this.txtValor.Location = new System.Drawing.Point(23, 100);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Name = "txtValor";
            this.txtValor.Numero = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtValor.PasswordChar = '\0';
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 7;
            this.txtValor.ShortcutsEnabled = true;
            this.txtValor.Size = new System.Drawing.Size(468, 23);
            this.txtValor.TabIndex = 0;
            this.txtValor.Text = "R$ 0,00";
            this.txtValor.UseSelectable = true;
            this.txtValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtValor.Validating += new System.ComponentModel.CancelEventHandler(this.txtValor_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAdicionarDinheiroCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(514, 317);
            this.Controls.Add(this.chkSubtrair);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtRazao);
            this.Controls.Add(this.lblRazao);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.MaximizeBox = false;
            this.Name = "frmAdicionarDinheiroCaixa";
            this.Resizable = false;
            this.Text = "Adicionar ou remover dinheiro do caixa";
            this.Load += new System.EventHandler(this.frmAdicionarDinheiroCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.CurrencyTextBox txtValor;
        private MetroFramework.Controls.MetroLabel lblValor;
        private MetroFramework.Controls.MetroLabel lblRazao;
        private MetroFramework.Controls.MetroTextBox txtRazao;
        private MetroFramework.Controls.MetroLink btnAdicionar;
        private MetroFramework.Controls.MetroCheckBox chkSubtrair;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}