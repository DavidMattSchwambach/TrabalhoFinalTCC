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
        [Column("produtos")]
        public decimal Produto { get; set; }

        [ForeignKey("IdFornecedores")]
        public Fornecedor fornecedor { get; set; }

        [Column("id_fornecedor")]
        public int IdFornecedor { get; set; }

        [ForeignKey("IdCompras")]
        public Compra compra { get; set; }

        [Column("id_compra")]
        public int IdCompra { get; set; }
    }
}
