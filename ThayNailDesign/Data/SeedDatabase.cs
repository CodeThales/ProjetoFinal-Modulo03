using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThayNailDesign.Models;

namespace ThayNailDesign.Data
{
    public class SeedDatabase
    {
        public static void Initialize(IHost app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var context = serviceProvider.GetRequiredService<ThayNailDesignContext>();
                context.Database.Migrate();

                if (!context.Cliente.Any())
                {
                    context.Cliente.Add(new Cliente { Nome = "Juliane", Telefone = "91111-1111", Nasc = new DateTime(2001, 01, 01) });
                    context.Cliente.Add(new Cliente { Nome = "Bárbara", Telefone = "92222-2222", Nasc = new DateTime(2002, 02, 02) });
                    context.Cliente.Add(new Cliente { Nome = "Letícia", Telefone = "93333-3333", Nasc = new DateTime(2003, 03, 03) });
                    context.Cliente.Add(new Cliente { Nome = "Débora", Telefone = "94444-4444", Nasc = new DateTime(2004, 04, 04) });
                    context.Cliente.Add(new Cliente { Nome = "Jessy", Telefone = "95555-5555", Nasc = new DateTime(2005, 05, 05) });
                    context.Cliente.Add(new Cliente { Nome = "Flávia", Telefone = "96666-6666", Nasc = new DateTime(2006, 06, 06) });
                    context.Cliente.Add(new Cliente { Nome = "Mariana", Telefone = "97777-7777", Nasc = new DateTime(2007, 07, 07) });
                    context.Cliente.Add(new Cliente { Nome = "Ingrid", Telefone = "98888-8888", Nasc = new DateTime(2008, 08, 08) });
                    context.Cliente.Add(new Cliente { Nome = "Simone", Telefone = "99999-9999", Nasc = new DateTime(2009, 09, 09) });
                    context.Cliente.Add(new Cliente { Nome = "Rosangela", Telefone = "91010-1010", Nasc = new DateTime(2010, 10, 10) });
                }
                context.SaveChanges();
            }
        }
    }
}
