 using Microsoft.EntityFrameworkCore;
 using CuidadoEquino.App.Dominio;

 namespace CuidadoEquino.App.Persistencia
 {
    public class AppContext : DbContext
    {
        public DbSet<AdminVeterinaria> AdminVeterinarias {get; set;}
        public DbSet<Caballo_Veterinario> Caballos_Veterinarios {get; set;}
        public DbSet<Caballo> Caballos {get; set;}
        public DbSet<Propietario> Propietarios {get; set;}
        public DbSet<Veterinario> Veterinarios {get; set;}
        public DbSet<IndicadoresdeSalud> IndicadoresdeSalud {get; set;}
        public DbSet<HistoriaClinica> HistoriasClinicas {get; set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                /* La siguiente instruccion es por el uso de SQL Server con Docker */
                //optionsBuilder.UseSqlServer("Server=.; Database=CuidadoCaninoDB; User Id=sa; Password=Password123;");
                
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=CuidadoCaninoDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminVeterinaria>().HasKey(c => c.Id);
            modelBuilder.Entity<Caballo_Veterinario>().HasKey(c => c.Id);
            modelBuilder.Entity<Caballo>().HasKey(c => c.Id);
            modelBuilder.Entity<HistoriaClinica>().HasKey(c => c.Id);
            modelBuilder.Entity<IndicadoresdeSalud>().HasKey(c => c.Id);
            modelBuilder.Entity<Propietario>().HasKey(c => c.Id);
            modelBuilder.Entity<Veterinario>().HasKey(c => c.Id);
        }
    }
 }
