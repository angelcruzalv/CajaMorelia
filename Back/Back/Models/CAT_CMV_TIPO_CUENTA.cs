using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Models
{
    public class CAT_CMV_TIPO_CUENTA
    {
        [Key]
        public int id_cuenta { get; set; }

        public string nombre_cuenta { get; set; }
    }
}
