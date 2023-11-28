using Microsoft.EntityFrameworkCore;
using RestDocentesAPI.Data.DTO;
using RestDocentesAPI.Data.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace RestDocentesAPI.Data
{
    public class DocentesContext : DbContext
    {
        public DbSet<Docente> Docentes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "DocentesDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region DocenteSeed
            var docente1 = new Docente
            {
                Id = "1",
                Nombre = "Docente 1",
                Especialidad = "Matematicas"
            };
            var docente2 = new Docente
            {
                Id = "2",
                Nombre = "Docente 2",
                Especialidad = "Ciencias"
            };
            var docente3 = new Docente
            {
                Id = "3",
                Nombre = "Docente 3",
                Especialidad = "Religion"
            };
            var docente4 = new Docente
            {
                Id = "4",
                Nombre = "Docente 4",
                Especialidad = "Lenguaje"
            };
            var docente5 = new Docente
            {
                Id = "5",
                Nombre = "Docente 5",
                Especialidad = "Historia"
            };
            var docente6 = new Docente
            {
                Id = "6",
                Nombre = "Docente 6",
                Especialidad = "Historia"
            };
            var docente7 = new Docente
            {
                Id = "7",
                Nombre = "Docente 7",
                Especialidad = "Historia"
            };
            var docente8 = new Docente
            {
                Id = "8",
                Nombre = "Docente 8",
                Especialidad = "Historia"
            };
            var docente9 = new Docente
            {
                Id = "9",
                Nombre = "Docente 9",
                Especialidad = "Historia"
            };
            var docente10 = new Docente
            {
                Id = "10",
                Nombre = "Docente 10",
                Especialidad = "Historia"
            };
            var docente11 = new Docente
            {
                Id = "11",
                Nombre = "Docente 11",
                Especialidad = "Historia"
            };

            modelBuilder.Entity<Docente>().HasData(new List<Docente> { docente1, docente2, docente3, docente4, docente5, docente6, docente7, docente8, docente9, docente10, docente11 });
            #endregion
        }
    }
}
