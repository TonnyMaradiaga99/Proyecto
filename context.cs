using Microsoft.EntityFrameworkCore;
using Proyecto.Models;

namespace Proyecto
{ 
    public class context:DbContext
    {
        public DbSet<Cita> Cita { get; set; }

        public DbSet<Doctor> Doctor { get; set; }

        public DbSet<Paciente> Paciente { get; set; }

        public context(DbContextOptions<context> options) : base(options){}

    }
}

