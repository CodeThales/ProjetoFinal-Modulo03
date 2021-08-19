using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ThayNailDesign.Models;

namespace ThayNailDesign.Data
{
    public class ThayNailDesignContext : IdentityDbContext
    {
        public ThayNailDesignContext(DbContextOptions<ThayNailDesignContext> options) : base(options)
        {                
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }

    }
}
