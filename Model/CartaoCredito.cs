using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("cartoes_credito")]
    public class CartaoCredito : Base
    {

        [Column("data_vencimento")]
        public DateTime DataVencimento { get; set; }

        [Column("cvv")]
        public decimal CVV { get; set; }

        [Column("id_cliente")]
        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }
    }
}
