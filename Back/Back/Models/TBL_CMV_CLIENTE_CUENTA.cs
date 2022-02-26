using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Back.Models
{
    public class TBL_CMV_CLIENTE_CUENTA
    {
        [Key]
        public int id_cliente_cuenta { get; set; }

        [ForeignKey("Cliente")]
        public int id_cliente { get; set; }

        [ForeignKey("CAT_CMV_TIPO_CUENTA")]
        public int id_cuenta { get; set; }

        [Column(TypeName = "money")]
        public decimal saldo_actual { get; set; }

        public DateTime fecha_contratacion { get; set; }

        public DateTime fecha_ultimo_movimiento { get; set; }


    }
}
