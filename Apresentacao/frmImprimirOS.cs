using Apresentacao.Validacoes;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using Modelo;
using MySql;
using System;
using System.Collections.Generic;

namespace Apresentacao
{
    public partial class frmImprimirOS : MetroForm
    {
        OSBanco osBanco = new OSBanco();
        public frmImprimirOS(uint codigo)
        {
            InitializeComponent();
            RegrasRelatorio();
            parametrosEmpresa();
            OS osImprimir = osBanco.ImprimirFolha(codigo);
            reportImprimir.LocalReport.SubreportProcessing += (o, e) =>
            {
                e.DataSources.Add(new ReportDataSource("dsOrdem", new List<OS>() { osImprimir }));
            };
        }

        private void frmImprimirOS_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
            reportImprimir.RefreshReport();
        }

        private void parametrosEmpresa()
        {
            ReportParameter[] parametros = new ReportParameter[5];
            parametros[0] = new ReportParameter("Empresa", Properties.Settings.Default.EmpresaDescricao);
            parametros[1] = new ReportParameter("Telefone", Properties.Settings.Default.TelefoneEmpresa);
            parametros[2] = new ReportParameter("CNPJ", Properties.Settings.Default.CNPJ);
            parametros[3] = new ReportParameter("Endereco", Properties.Settings.Default.EnderecoEmpresa);
            parametros[4] = new ReportParameter("Celular", Properties.Settings.Default.CelularEmpresa);
            reportImprimir.LocalReport.SetParameters(parametros);
        }

        public void RegrasRelatorio()
        {
            reportImprimir.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportImprimir.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportImprimir.ZoomPercent = 100;
        }
    }
}
