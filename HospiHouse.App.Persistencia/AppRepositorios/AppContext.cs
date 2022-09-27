using Microsoft.EntityFrameworkCore;
using System;
using HospiHouse.App.Dominio;

namespace HospiHouse.App.Persistencia 
{
    public class AppContext : DbContext
    {
        public DbSet <Paciente> pacientes {get;set;}
        public DbSet <Familiar> familiares {get;set;}
        public DbSet <Auxiliar> auxiliares {get;set;}
        public DbSet <Enfermera> enfermeras {get;set;}
        public DbSet <Medico> medicos {get;set;}

        public DbSet <HistoriaMedica> historiasMedicas {get;set;}
        public DbSet <SignosVitales> signosVitales {get;set;}
        public DbSet <SugerenciaCuidado> sugerenciasCuidado {get;set;}


        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer ("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog= HospiHouseData2");
            }
        }
    }
}


