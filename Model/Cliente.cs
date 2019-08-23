using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente
    {
        [Column("nome")]
        public string Nome { get; set; }

        [Column("data_nascimento")]
        public DateTime DataNascimento { get; set; }

        [Column("cpf")]

        public string Cpf { get; set; }

        [Column("telefone")]

        public string Telefone { get; set; }

        [Column("email")]

        public string Email { get; set; }

        [Column("senha")]

        public string Senha { get; set; }
    }
}
