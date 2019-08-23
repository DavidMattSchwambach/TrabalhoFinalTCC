using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("marcas")]
    public class Marca
    {
        [Column("nome")]
        public string Nome { get; set; }

    }
}
