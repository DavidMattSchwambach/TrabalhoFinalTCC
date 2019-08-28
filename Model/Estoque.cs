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
        public decimal Valor { get; set; }

        [ForeignKey("IdFornecedores")]
        public Fornecedor fornecedor { get; set; }

        [ForeignKey("IdCompras")]
        public Compra compra { get; set; }
    }
}
