using Microsoft.EntityFrameworkCore;

namespace Parcial1_Enun8v4.Data.Entidades
{
    public class ContextoBaseDatos : DbContext
    {
        public ContextoBaseDatos(DbContextOptions<ContextoBaseDatos> options) : base(options)
        {

        }

        //DbSet: Mapeo o asignación de cada una de las clases para que puedan ser tomadas
        //      y leidas en la base de datos
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Conversacion> Conversaciones { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Interes> Intereses { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }


        //Conexión a la base de datos (se hace en el appsettings)
        //para pasarla como parametro al constructor
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>().HasIndex(c => c.Id_Cliente).IsUnique();
            modelBuilder.Entity<Compra>().HasIndex(c => c.Id_Compra).IsUnique();
            modelBuilder.Entity<Conversacion>().HasIndex(c => c.Id_Conversacion).IsUnique();
            modelBuilder.Entity<Empleado>().HasIndex(c => c.Id_Empleado).IsUnique();
            modelBuilder.Entity<Interes>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<Vehiculo>().HasIndex(c => c.Id_Vehiculo).IsUnique();
        }

    }
}

