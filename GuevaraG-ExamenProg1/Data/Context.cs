using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GuevaraG_ExamenProg1.Models;

namespace GuevaraG_ExamenProg1.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<GuevaraG_ExamenProg1.Models.Recompensa> Recompensa { get; set; } = default!;
        public DbSet<GuevaraG_ExamenProg1.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<GuevaraG_ExamenProg1.Models.Reserva> Reserva { get; set; } = default!;
    }
}
