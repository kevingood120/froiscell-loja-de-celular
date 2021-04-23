using Modelo;
using MySql;
using System.Drawing;
using System.Drawing.Printing;

namespace Apresentacao.Cupons
{
    public class CupomOS : PrintDocument
    {
        OS ordemServico;
        OSBanco osBanco = new OSBanco();

        public CupomOS(uint codigo)
        {
            ordemServico = osBanco.ImprimirCupom(codigo);
            PrinterSettings.PrinterName = Properties.Settings.Default.ImpressoraCupom;
            PrinterSettings.PrintFileName = "Cupom de OS";
        }

        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            int linhaPrincipal = 0;
            Brush cor = Brushes.Black;
            Font fontComum = new Font("Arial", 10);
            Font fontNegrito = new Font(fontComum, FontStyle.Bold);
            using (Graphics g = e.Graphics)
            {              
                g.DrawString(Properties.Settings.Default.Empresa, fontComum, cor, 0, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 20;
                g.DrawString("CNPJ: " + Properties.Settings.Default.CNPJ, fontComum, cor, 0, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 20;
                g.DrawString(Properties.Settings.Default.EnderecoEmpresa, fontComum, cor, 0, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 20;
                g.DrawString("Telefone: " + Properties.Settings.Default.TelefoneEmpresa, fontComum, cor, 0, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 20;
                g.DrawString("Dados da venda", fontNegrito, cor, 85, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 20;
                g.DrawString("Cliente: " + ordemServico.ClienteSelecionado.Nome_cliente.Split(' ')[0], fontComum, cor, 0, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 20;
                g.DrawString("CPF: " + ordemServico.ClienteSelecionado.Cpf_cliente, fontComum, cor, 0, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 20;
                g.DrawString("Entrada: " + ordemServico.Reg_entrada.ToString("dd/MM/yyyy HH:mm") , fontComum, cor, 0, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 20;
                g.DrawString("Saída: " + ordemServico.Reg_saida.Value.ToString("dd/MM/yyyy HH:mm"), fontComum, cor, 0, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 20;
                g.DrawString("Descrição da OS", fontNegrito, cor, 85, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 30;
                g.DrawString("Código da OS: " + ordemServico.Cod_ordem, fontComum, cor, 0, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 20;
                g.DrawString("Tipo: " + ordemServico.AparelhoSelecionado.TipoSelecionado, fontComum, cor, 0, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 20;
                g.DrawString("Marca: " + ordemServico.AparelhoSelecionado.MarcaSelecionada.Nome_marca, fontComum, cor, 0, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 20;
                g.DrawString("Modelo: " + ordemServico.AparelhoSelecionado.Modelo_aparelho, fontComum, cor, 0, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 20;
                g.DrawString("Cor: " + ordemServico.CorSelecionada.Nome_cor, fontComum, cor, 0, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 20;
                if (ordemServico.Rec_aparelho.Length > 26)
                {
                    string reclamacao = ordemServico.Rec_aparelho.Substring(0, 26) + "\n" + ordemServico.Rec_aparelho.Substring(26);
                    g.DrawString("Reclamação: " + reclamacao.ToLower(), fontComum, cor, 0, linhaPrincipal);
                    linhaPrincipal = linhaPrincipal + 35;
                }
                else
                {
                    g.DrawString("Reclamação: " + ordemServico.Rec_aparelho.ToLower(), fontComum, cor, 0, linhaPrincipal);
                    linhaPrincipal = linhaPrincipal + 20;
                }

                if (ordemServico.Orc_descricao.Length > 30)
                {
                    string descricao = ordemServico.Orc_descricao.Substring(0, 30) + "\n" + ordemServico.Orc_descricao.Substring(30);
                    g.DrawString("Orçamento: " + descricao.ToLower(), fontComum, cor, 0, linhaPrincipal);
                    linhaPrincipal = linhaPrincipal + 35;
                }
                else
                {
                    g.DrawString("Orçamento: " + ordemServico.Orc_descricao.ToLower(), fontComum, cor, 0, linhaPrincipal);
                    linhaPrincipal = linhaPrincipal + 20;
                }
                g.DrawString("Pagamento(s)", fontNegrito, cor, 90, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 30;
                foreach (Pagamento pagamento in ordemServico.PagamentoColecao)
                {
                    string item = pagamento.PagamentoSelecionado != Modelo.Enums.Pagamentos.Crédito ? pagamento.Valor.ToString("C2") : pagamento.Vezes.Value.ToString() + " X " + (pagamento.Valor / pagamento.Vezes.Value).ToString("C2");
                    g.DrawString(pagamento.PagamentoSelecionado + ": " + item, fontComum, cor, 0, linhaPrincipal);
                    linhaPrincipal = linhaPrincipal + 20;
                }
                g.DrawString("Total: " + ordemServico.PagamentoColecao.Total.ToString("C2"), fontNegrito, cor, 0, linhaPrincipal);
            }
            base.OnPrintPage(e);
        }
    }
}
