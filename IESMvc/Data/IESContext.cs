using IESMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace IESMvc.Data
{
    public class IESContext : DbContext
    {
        public IESContext(DbContextOptions<IESContext> options) : base(options) {}


        public DbSet<Institucion> Instituciones { get; set; }
        public DbSet<Departamento> Departamentos { get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Departamento>().ToTable("Departamento");
            modelBuilder.Entity<Institucion>().ToTable("Institucion");
        }
    }
}
