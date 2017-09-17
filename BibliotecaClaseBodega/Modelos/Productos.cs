using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClaseBodega.Modelos
{
    /// <summary>
    /// Clase Producto -- Con EntityFramework -- Se mapea como Tabla Producto
    /// La clase extiende las propiedades de la clase BaseEntity
    /// </summary>
    public class Productos:BaseEntity
    {
        // Defino campos menos el PK
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public bool Estado { get; set; }

    }
}
