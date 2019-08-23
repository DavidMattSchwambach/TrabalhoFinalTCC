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
        public int Nome { get; set; }

        [Column("preco")]
        public int Preco { get; set; }

        [ForeignKey("IdTipos")]
        public Tipo Tipo { get; set; }
    }
}
