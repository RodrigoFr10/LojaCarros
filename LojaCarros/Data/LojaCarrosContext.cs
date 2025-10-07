using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LojaCarros.Models;

namespace LojaCarros.Data
{
    public class LojaCarrosContext : DbContext
    {
        public LojaCarrosContext (DbContextOptions<LojaCarrosContext> options)
            : base(options)
        {
        }

        public DbSet<LojaCarros.Models.Carro> Carro { get; set; } = default!;

        public DbSet<LojaCarros.Models.Cliente>? Cliente { get; set; }

        public DbSet<LojaCarros.Models.Nota>? Nota { get; set; }

        public DbSet<LojaCarros.Models.Vendedor>? Vendedor { get; set; }
    }
}
