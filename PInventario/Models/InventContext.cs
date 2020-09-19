using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PInventario.Models
{
    public class InventContext: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }
        public DbSet<Categoria> Categorias  { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }
        public DbSet<MovimientoDetalle> Movimiento_detalles { get; set; }
        public DbSet<Papeleria> Papelerias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ReporteProducto> Reporte_productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public InventContext()
        {

        }

    }
}