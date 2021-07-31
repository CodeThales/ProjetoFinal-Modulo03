using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThayNailDesign.Models;

namespace ThayNailDesign.Data
{
    public class ThayNailDesignContext : DbContext
    {
        public ThayNailDesignContext(DbContextOptions<ThayNailDesignContext> options) : base(options)
        {                
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Servico> Servico { get; set; }
    }
}
