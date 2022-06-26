using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CrudMVVM.Modelos;
using Xamarin.Forms;

namespace CrudMVVM.Datos
{
    public class BaseDatos : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }

        private readonly string rutaBD;

        public BaseDatos(string rutaBD)
        {
            this.rutaBD = rutaBD;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = DependencyService.Get<IBaseDatos>().GetDatabasePath();
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}
