using ClosedXML.Excel;
using Model;
using Repository.Repository;
using System;
using System.Collections.Generic;

namespace Excel
{
    public class ClodesXml
    {

        public static void Main(string[] args)
        {
            ClienteRepository repository = new ClienteRepository();

            List<Cliente> clientes = repository.ObterTodos("");

            var wb = new XLWorkbook();

            var ws = wb.Worksheets.Add("Planilha 1");

            ws.Cell("B2").Value = "Lista de Clientes";
            var range = ws.Range("B2:I2");
            range.Merge().Style.Font.SetBold().Font.FontSize = 20;

            ws.Cell("B3").Value = "Nome";
            ws.Cell("E3").Value = "Data De Nascimento";
            ws.Cell("C3").Value = "CPF";
            ws.Cell("D3").Value = "Telefone";
            ws.Cell("G3").Value = "Usuario"; ;
            ws.Cell("F3").Value = "Email";
            ws.Cell("H3").Value = "Senha";
            ws.Cell("I3").Value = "Item Mais Comprado";

            var linha = 4;

            for (int i = 0; i < clientes.Count; i++)
            {
                ws.Cell("B" + linha.ToString()).Value = clientes + i.ToString();
            }

            range = ws.Range("B3:I" + linha.ToString());
            range.CreateTable();

            ws.Columns("2 - 9").AdjustToContents();

            wb.SaveAs("C:/Users/CNBarbaNegra/Desktop/Excel/teste_tne.xlsx");

            wb.Dispose();

            Console.WriteLine("Feito!");
            Console.ReadKey();
        }
    }
}
