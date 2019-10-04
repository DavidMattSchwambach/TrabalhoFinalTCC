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
                var cliente = clientes[i];

                ws.Cell("B" + (i + linha)).Value = cliente.Nome;
                ws.Cell("C" + (i + linha)).Value = cliente.Cpf;
                ws.Cell("D" + (i + linha)).Value = cliente.Telefone;
                ws.Cell("E" + (i + linha)).Value = cliente.DataNascimento;
                ws.Cell("F" + (i + linha)).Value = cliente.Email;
                ws.Cell("G" + (i + linha)).Value = cliente.Usuario;
                ws.Cell("H" + (i + linha)).Value = cliente.Senha;
            }

            range = ws.Range("B3:I" + linha.ToString());
            range.CreateTable();

            ws.Columns("2 - 9").AdjustToContents();

            wb.SaveAs("C:/Users/65971/Desktop/Excel/teste_tne.xlsx");

            wb.Dispose();

            Console.WriteLine("Feito!");
            Console.ReadKey();
        }
    }
}
