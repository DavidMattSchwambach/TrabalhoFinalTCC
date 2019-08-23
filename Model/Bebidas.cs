using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("bebidas")]
    class Bebidas
    {
        [Column("nome")]
        public string Tipo { get; set; }
        [Column("valor")]
        public string Valor { get; set; }

        [ForeignKey("IdTipo")]
        public Tipo tipo { get; set; }

        [Column("id_tipo")]
        public int IdTipo { get; set; }
        public bool RegistroAtivo { get; set; }
    }
}
