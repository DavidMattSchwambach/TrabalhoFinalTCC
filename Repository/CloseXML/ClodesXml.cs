using ClosedXML.Excel;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.CloseXML
{
    class ClodesXml
    {
        static void Main(string[] args)
        {

            var wb = new XLWorkbook();

            var ws = wb.Worksheets.Add("Planilha 1");

            ws.Cell("B2").Value = "Teste ClosedXML 2";
            var range = ws.Range("B2:I2");
            range.Merge().Style.Font.SetBold().Font.FontSize = 20;

            ws.Cell("B3").Value = "Nome";
            ws.Cell("E3").Value = "Data De Nascimento";
            ws.Cell("C3").Value = "CPF";
            ws.Cell("D3").Value = "Telefone";
            ws.Cell("G3").Value = "Usuario";
            ws.Cell("F3").Value = "Email";
            ws.Cell("H3").Value = "Senha";
            ws.Cell("I3").Value = "Item Mais Comprado";

            var linha = 4;

            for (int i = 0; i < 20; i++)
            {
                ws.Cell("B" + linha.ToString()).Value = "B" + i.ToString();
                ws.Cell("C" + linha.ToString()).Value = "C" + i.ToString();
                ws.Cell("D" + linha.ToString()).Value = "D" + i.ToString();
                ws.Cell("E" + linha.ToString()).Value = "E" + i.ToString();
                ws.Cell("F" + linha.ToString()).Value = "F" + i.ToString();
            }

            range = ws.Range("B3:I" + linha.ToString());
            range.CreateTable();

            ws.Columns("2 - 9").AdjustToContents();

            wb.SaveAs("C:/Users/65978/Desktop/Excel/teste2_tne.xlsx");

            wb.Dispose();

            Console.WriteLine("Feito!");
            Console.ReadKey();
        }
    }
}
