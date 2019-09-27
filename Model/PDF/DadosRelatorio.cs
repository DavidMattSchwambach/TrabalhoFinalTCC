using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.PDF
{
    public class DadosRelatorio
    {
        public List<Duplicata> duplicatas { get; set; }
        public List<Cliente> cliente { get; set; }

        public DadosRelatorio()
        {
            duplicatas = new List<Duplicata>();

            var cliente = new Cliente();
            cliente.Id = 1;
            cliente.Nome = "Jotaro DioBrando";

            var duplicata = new Duplicata();
            duplicata.cliente = cliente;
            duplicata.Numero = "1233589-01";
            duplicata.Emissao = new DateTime(2016, 6, 1);
            duplicata.Vencimento = new DateTime(2016, 6, 15);
            duplicata.Valor = 23125;
            duplicata.Saldo = 1500M;
            duplicatas.Add(duplicata);
            duplicata = null;

            duplicata = new Duplicata();
            duplicata.cliente = cliente;
            duplicata.Numero = "0003589-01";
            duplicata.Emissao = new DateTime(2019, 06, 01);
            duplicata.Vencimento = new DateTime(2019, 09, 27);
            duplicata.Valor = 1500M;
            duplicata.Saldo = 1500M;
            duplicatas.Add(duplicata);
            duplicata = null;

        }
    }
}
