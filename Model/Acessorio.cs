using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("acessorios")]
    public class Acessorio : Base
    {
        [Column("nome")]
        public string Nome { get; set; }

        [Column("preco")]
        public decimal Preco { get; set; }

        [Column("id_tipo")]
        public int IdTipo { get; set; }

        [ForeignKey("IdTipo")]
        public Tipo Tipo { get; set; }
    }
}
