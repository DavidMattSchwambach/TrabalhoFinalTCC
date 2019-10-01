using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("compras")]
    public class Compra : Base
    {
        [Column("total")]
        public decimal Total { get; set; }

        [Column("data_compra")]
        public DateTime DataCompra { get; set; }

        [Column("id_cartao_credito")]
        public int? IdCartaoCredito { get; set; }

        [ForeignKey("IdCartaoCredito")]
        public CartoesCredito CartaoCredito { get; set; }

        [Column("id_cliente")]
        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }

    }
}
