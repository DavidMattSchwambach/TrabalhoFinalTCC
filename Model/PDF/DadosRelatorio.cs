namespace Model
{
    using System;
    using System.Collections.Generic;

    public class DadosRelatorio
    {
        public List<Duplicata> duplicatas { get; set; }

        public DadosRelatorio()
        {
            duplicatas = new List<Duplicata>();

            var cliente = new Cliente();
            cliente.Id = 1;
            cliente.Nome = "Breno";

            var duplicata = new Duplicata();
            duplicata.cliente = cliente;
            duplicata.Numero = "0003589-01";
            duplicata.Emissao = new DateTime(2016, 6, 1);
            duplicata.Vencimento = new DateTime(2016, 6, 15);
            duplicata.Valor = 210M;
            duplicatas.Add(duplicata);
            duplicata = null;


            cliente = new Cliente();
            cliente.Id = 2;
            cliente.Nome = "Max";

            duplicata = new Duplicata();
            duplicata.cliente = cliente;
            duplicata.Numero = "1003329-02";
            duplicata.Emissao = new DateTime(2016, 6, 2);
            duplicata.Vencimento = new DateTime(2016, 6, 5);
            duplicata.Valor = 43M;
            duplicatas.Add(duplicata);
            duplicata = null;


            cliente = new Cliente();
            cliente.Id = 3;
            cliente.Nome = "David";

            duplicata = new Duplicata();
            duplicata.cliente = cliente;
            duplicata.Numero = "0003333-01";
            duplicata.Emissao = new DateTime(2016, 6, 9);
            duplicata.Vencimento = new DateTime(2016, 7, 10);
            duplicata.Valor = 23.30M;
            duplicatas.Add(duplicata);
            duplicata = null;

        }
    }
}
