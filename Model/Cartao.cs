using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("cartoes_credito")]
    public class CartoesCredito : Base
    {

        [Column("numero")]
        public string Numero { get; set; }

        [Column("data_vencimento")]
        public DateTime DataCompra { get; set; }

        public int IdCartaoCredito { get; set; }
        [ForeignKey("IdCartoesCredito")]
        public CartoesCredito CartaoCredito { get; set; }
    }
}
