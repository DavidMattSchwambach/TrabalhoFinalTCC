using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("fornecedores")]
    public class Fornecedor : Base
    {
        [Column("nome")]
        public string Nome { get; set; }

        [Column("preco")]
        public decimal Preco { get; set; }

        [ForeignKey("IdMarca")]
        public Marca marca { get; set; }

        [Column("id_marca")]
        public int IdMarcas { get; set; }
    }
}
