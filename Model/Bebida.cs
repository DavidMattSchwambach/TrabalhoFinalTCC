﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("bebidas")]
    public class Bebida : Base
    {
        [Column("nome")]
        public string Nome { get; set; }

        [Column("valor")]
        public decimal Valor { get; set; }

        [ForeignKey("IdTipo")]
        public Tipo Tipo { get; set; }

        [Column("id_tipo")]
        public int IdTipo { get; set; }

        [ForeignKey("IdMarca")]
        public Marca Marca { get; set; }

        [Column("id_marca")]
        public int IdMarca { get; set; }

    }
}
