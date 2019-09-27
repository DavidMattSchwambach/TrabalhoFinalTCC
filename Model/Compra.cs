using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("compras")]
    public class Compra : Base
    {
        [Column("produto")]
        public string Produto { get; set; }

        [Column("frete")]
        public decimal Frete { get; set; }

        [Column("valor")]
        public decimal Valor { get; set; }

        [Column("quantidade")]
        public int Quantidade { get; set; }

        [Column("total")]
        public decimal Total { get; set; }

        [Column("data_compra")]
        public DateTime DataCompra { get; set; }

        [Column("id_cartao_credito")]
        public int IdCartaoCredito { get; set; }

        [ForeignKey("IdCartaoCredito")]
        public CartoesCredito CartaoCredito { get; set; }

        [Column("id_bebida")]
        public int IdBebida { get; set; }

        [ForeignKey("IdBebida")]
        public Bebida Bebidas { get; set; }

        [Column("id_acessorio")]
        public int IdAcessorio { get; set; }

        [ForeignKey("IdAcessorio")]
        public Acessorio Acessorios { get; set; }
    }
}
