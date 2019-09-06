using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("bebidas")]
    public class LoginCliente : Base
    {

        [Column("usuario")]
        public string usuario { get; set; }


        [Column("senha")]
        public string senha { get; set; }

    }

}
