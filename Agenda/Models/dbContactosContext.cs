using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Agenda.Models
{
    public partial class dbContactosContext : DbContext
    {
        public dbContactosContext()
        {
        }

        public dbContactosContext(DbContextOptions<dbContactosContext> options)
            : base(options) {}

        //aqui declaro las tablas que voy a utilizar en mi base de datos

        public DbSet<Contacto> Contactos { get; set; }

        
    }
}
