using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("administradores")]
    public class Administrador : Base
    {
        [Column("usuario")]
        public string Usuario { get; set; }

        [Column("senha")]
        public string Senha { get; set; }

    }
    
}
