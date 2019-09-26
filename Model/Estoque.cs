using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("estoque")]
    public class Estoque : Base
    {

        [ForeignKey("IdFornecedor")]
        public Fornecedor Fornecedor { get; set; }

        [Column("id_fornecedor")]
        public int IdFornecedor { get; set; }

        [ForeignKey("IdCompra")]
        public Compra Compra { get; set; }

        [Column("id_compra")]
        public int IdCompra { get; set; }

        [ForeignKey("IdBebida")]
        public Bebida Bebida { get; set; }

        [Column("id_bebida")]
        public int IdBebida { get; set; }

        [ForeignKey("IdAcessorio")]
        public Acessorio Acessorio { get; set; }

        [Column("id_acessorio")]
        public int IdAcessorio{ get; set; }
    }
}
