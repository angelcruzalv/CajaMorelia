using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Back.Models;

namespace Back.Data
{
    public class BackContext : DbContext
    {
        public BackContext (DbContextOptions<BackContext> options)
            : base(options)
        {
        }

        public DbSet<Back.Models.Cliente> Cliente { get; set; }

        public DbSet<Back.Models.CAT_CMV_TIPO_CUENTA> CAT_CMV_TIPO_CUENTA { get; set; }

        public DbSet<Back.Models.TBL_CMV_CLIENTE_CUENTA> TBL_CMV_CLIENTE_CUENTA { get; set; }
    }
}
