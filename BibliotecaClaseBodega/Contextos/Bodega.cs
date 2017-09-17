using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClaseBodega.Modelos;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BibliotecaClaseBodega.Contextos
{
    /// <summary>
    /// Creo un Constructor para el ConnectionString
    /// </summary>
    public class Bodega:DbContext
    {
        public Bodega():base("BodegaDB") { }
        // metodo para ingresar registros a la clase Producto -- mapeado a tabla
        public DbSet<Productos> Productos { get; set; }
        // para no pluralizar al convertir en tablas de SQL
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
