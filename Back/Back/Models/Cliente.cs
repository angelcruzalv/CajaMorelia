using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Models
{
    public class Cliente
    {
        [Key]
        public int id_cliente { get; set; }

        public string nombre { get; set; }

        public string apellido_paterno { get; set; }

        public string apellido_materno { get; set; }

        public string rfc { get; set; }

        public string curp { get; set; }

        public DateTime fecha_alta { get; set; }
    }
     
}
