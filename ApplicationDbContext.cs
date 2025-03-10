using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace TiendaMinorista.Datos
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        // DbSets para las entidades del modelo
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetalleFactura> DetallesFactura { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=JUAN;Database=MiTiendaDB;Trusted_Connection=True");
            }
        }

        // Configuración de la base de datos y relaciones entre las entidades
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de herencia: tanto Cliente como Proveedor heredan de Persona
            modelBuilder.Entity<Cliente>()
                .HasBaseType<Persona>();  // Relaciona Cliente con Persona

            modelBuilder.Entity<Proveedor>()
                .HasBaseType<Persona>();  // Relaciona Proveedor con Persona

            // Configurar la relación entre Factura y DetalleFactura (uno a muchos)
            modelBuilder.Entity<DetalleFactura>()
                .HasOne(d => d.Factura)
                .WithMany(f => f.DetallesFactura)
                .HasForeignKey(d => d.FacturaId);

            // Relación entre DetalleFactura y Producto (uno a muchos)
            modelBuilder.Entity<DetalleFactura>()
                .HasOne(d => d.Producto)
                .WithMany()
                .HasForeignKey(d => d.ProductoId);

            // Otras configuraciones adicionales según sea necesario
        }
    }

}
