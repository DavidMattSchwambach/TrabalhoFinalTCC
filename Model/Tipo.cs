using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("tipos")]
    public class Tipo : Base
    {
        [Column("nome")]
        public string Nome { get; set; }

        [ForeignKey("IdMarca")]
        public Marca Marca { get; set; }

        [Column("id_marca")]
        public int IdMarcas { get; set; }

       
    }
}
