using Modelo;
using MySql;
using System;
using System.Drawing;
using System.Drawing.Printing;

namespace Apresentacao.Cupons
{
    public class CupomVenda : PrintDocument
    {
        Venda venda;
        VendaBanco vendaBanco = new VendaBanco();

        public CupomVenda(uint codigo)
        {
            string impressora = Properties.Settings.Default.ImpressoraCupom;        
            venda = vendaBanco.PesquisarPorCodigo(codigo);
            PrinterSettings.PrinterName = Properties.Settings.Default.ImpressoraCupom;
            PrinterSettings.PrintFileName = "Cupom de Venda";
        }

        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            int linhaPrincipal = 0;
            int LinhaSecundaria = 0;
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
                g.DrawString("Cliente: " + venda.ClienteSelecionado.Nome_cliente.Split(' ')[0], fontComum, cor, 0, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 20;
                g.DrawString("CPF: " + venda.ClienteSelecionado.Cpf_cliente, fontComum, cor, 0, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 20;
                g.DrawString("Data e Hora: " + venda.Reg_venda.ToString("dd/MM/yyyy HH:mm"), fontComum, cor, 0, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 20;
                g.DrawString("Produto(s)", fontNegrito, cor, 100, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 20;
                foreach (ItemVenda item in venda.Itens)
                {
                    g.DrawString(item.ProdutoSelecionado.GrupoSelecionado.Nome_grupo + " - " + item.ProdutoSelecionado.Desc_produto, fontComum, cor, 0, linhaPrincipal);
                    string linha = item.ProdutoSelecionado.Preco_produto.ToString("C2") + " X " + item.Quantidade.ToString() + " = " + item.Subtotal.ToString("C2");
                    LinhaSecundaria = linhaPrincipal + 20;
                    g.DrawString(linha, fontComum, cor, 50, LinhaSecundaria);
                    linhaPrincipal = linhaPrincipal + 40;
                }
                linhaPrincipal = LinhaSecundaria + 20;
                g.DrawString("Pagamento(s)", fontNegrito, cor, 90, linhaPrincipal);
                linhaPrincipal = linhaPrincipal + 30;
                foreach (Pagamento pagamento in venda.PagamentoColecao)
                {
                    string item = pagamento.PagamentoSelecionado != Modelo.Enums.Pagamentos.Crédito ? pagamento.Valor.ToString("C2") : pagamento.Vezes.Value.ToString() + " X " + (pagamento.Valor / pagamento.Vezes.Value).ToString("C2");
                    g.DrawString(pagamento.PagamentoSelecionado + ": " + item, fontComum, cor, 0, linhaPrincipal);
                    linhaPrincipal = linhaPrincipal + 20;
                }
                g.DrawString("Total: " + venda.PagamentoColecao.Total.ToString("C2"), fontNegrito, cor, 0, linhaPrincipal);
            }
            base.OnPrintPage(e);
        }
    }
}
