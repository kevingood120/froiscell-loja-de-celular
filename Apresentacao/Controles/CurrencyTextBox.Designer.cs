namespace Apresentacao.Controles
{
    partial class CurrencyTextBox
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CurrencyTextBox
            // 
            // 
            // 
            // 
            this.CustomButton.Image = null;
            this.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.CustomButton.Name = "";
            this.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.CustomButton.TabIndex = 1;
            this.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomButton.UseSelectable = true;
            this.CustomButton.Visible = false;
            this.Lines = new string[0];
            this.TextChanged += new System.EventHandler(this.CurrencyTextBox_TextChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrencyTextBox_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
