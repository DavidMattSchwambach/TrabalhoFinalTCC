using iTextSharp.text;
using iTextSharp.text.pdf;
using Model;
using Repository.DataBase;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.PDF
{
    public class RelatorioDuplicata : TNEReport
    {
        public RelatorioDuplicata()
        {
            Paisagem = false;
        }

        public override void MontaCorpoDados()
        {
            base.MontaCorpoDados();

            #region Cabeçalho do Relatório
            PdfPTable table = new PdfPTable(5);
            BaseColor preto = new BaseColor(0, 0, 0);
            BaseColor fundo = new BaseColor(200, 200, 200);
            Font font = FontFactory.GetFont("Verdana", 8, Font.NORMAL, preto);
            Font titulo = FontFactory.GetFont("Verdana", 8, Font.BOLD, preto);

            float[] colsW = { 10, 10, 10, 10, 10 };
            table.SetWidths(colsW);
            table.HeaderRows = 1;
            table.WidthPercentage = 100f;

            table.DefaultCell.Border = PdfPCell.BOTTOM_BORDER;
            table.DefaultCell.BorderColor = preto;
            table.DefaultCell.BorderColorBottom = new BaseColor(255, 255, 255);
            table.DefaultCell.Padding = 10;

            table.AddCell(getNewCell("Produto", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo));
            table.AddCell(getNewCell("Quantidade", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo));
            table.AddCell(getNewCell("Marca", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo));
            table.AddCell(getNewCell("Valor", titulo, Element.ALIGN_RIGHT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo));
            table.AddCell(getNewCell("Total", titulo, Element.ALIGN_RIGHT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo));
            #endregion

            var compras = new CompraProdutoRepository().ObterTodos();
            var clienteOld = string.Empty;

            foreach (var compra in compras)
            {
                //if (d.cliente.Nome != clienteOld)
                //{
                //    var cell = getNewCell(d.cliente.Nome, titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER);
                //    cell.Colspan = 5;
                //    table.AddCell(cell);
                //    clienteOld = d.cliente.Nome;
                //}

                table.AddCell(getNewCell(compra.Bebida.Nome, font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER));
                table.AddCell(getNewCell(compra.Quantidade.ToString(), font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER));
                table.AddCell(getNewCell(compra.Bebida.Marca.Nome, font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER));
                table.AddCell(getNewCell(compra.Bebida.Valor.ToString(), font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER));
                table.AddCell(getNewCell(compra.ValorTotal.ToString(), font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER));

            }

            doc.Add(table);
        }
    }
}
