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

        [Column("valor")]
        public string Valor { get; set; }

        [Column("dataCompra")]
        public DateTime DataCompra { get; set; }

        public int IdCartaoCredito { get; set; }
        [ForeignKey("IdCartaoCredito")]
        public CartoesCredito Cartoes { get; set; }

        public int IdBebidas { get; set; }
        [ForeignKey("IdBebidas")]
        public Bebida Bebidas { get; set; }

        public int IdAcessorios { get; set; }
        [ForeignKey("IdAcessorios")]
        public Acessorio Acessorios { get; set; }
    }
}
