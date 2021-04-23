namespace Apresentacao
{
    partial class frmEstoqueMinimo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportEstoque = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdutoBindingSource
            // 
            this.ProdutoBindingSource.DataSource = typeof(Modelo.Produto);
            // 
            // reportEstoque
            // 
            this.reportEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsProdutos";
            reportDataSource1.Value = this.ProdutoBindingSource;
            this.reportEstoque.LocalReport.DataSources.Add(reportDataSource1);
            this.reportEstoque.LocalReport.ReportEmbeddedResource = "Apresentacao.Relatorios.EstoqueMinimo.rdlc";
            this.reportEstoque.Location = new System.Drawing.Point(10, 60);
            this.reportEstoque.Name = "reportEstoque";
            this.reportEstoque.ServerReport.BearerToken = null;
            this.reportEstoque.Size = new System.Drawing.Size(546, 288);
            this.reportEstoque.TabIndex = 0;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // frmEstoqueMinimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 358);
            this.Controls.Add(this.reportEstoque);
            this.Name = "frmEstoqueMinimo";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.Resizable = false;
            this.Text = "Estoque Mínimo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEstoqueMinimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportEstoque;
        private System.Windows.Forms.BindingSource ProdutoBindingSource;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}