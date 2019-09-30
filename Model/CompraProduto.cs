using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Compras_Produto")]
    public class CompraProduto : Base
    {
        [Column("id_Compra")]
        public int IdCompra { get; set; }

        [ForeignKey("IdCompra")]
        public Compra Compra { get; set; }

        [Column("id_Bebida")]
        public int? IdBebida { get; set; }

        [ForeignKey("IdBebida")]
        public Bebida Bebida { get; set; }

        [Column("id_Acessorio")]
        public int? IdAcessorio { get; set; }

        [ForeignKey("IdAcessorio")]
        public Acessorio Acessorio { get; set; }
    }
}
