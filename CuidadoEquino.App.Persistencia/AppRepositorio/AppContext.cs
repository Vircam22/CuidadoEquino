 using Microsoft.EntityFrameworkCore;
 using CuidadoEquino.App.Dominio;

 namespace CuidadoEquino.App.Persistencia
 {
    public class AppContext : DbContext
    {
        public DbSet<Caballo> Caballos {get; set;}
        public DbSet<Propietario> Propietarios {get; set;}
        public DbSet<Veterinario> Veterinarios {get; set;}
        public DbSet<IndicadoresdeSalud> IndicadoresdeSalud {get; set;}
        public DbSet<HistoriaClinica> HistoriasClinicas {get; set;}

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .useSqlServer("DataSource=(localdb)\\MSSQLLocalDB; inicial Catalog= CuidadoEquino.Data");
        }
    }
 }
