using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // para utilizar el required
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClaseBodega.Modelos
{
    /// <summary>
    /// Tabla Marca
    /// </summary>
    public class Marca : BaseEntity
    {
        //campos -Los String con la etiqueta required hago NO NULL
        [Required]
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        //Relacion con la tabla Productos
        public ICollection<Productos> Productos { get; set; }

        //relacion muchos a muchos con proveedor
        public ICollection<Proveedor> Proveedores { get; set; }

        //instancio una conexion a productos para no perder los datos de memoria y que sean agregados en la tabla
        public Marca() : base()
        {
            this.Productos = new HashSet<Productos>();
            this.Proveedores = new HashSet<Proveedor>();
        }
    }
}
