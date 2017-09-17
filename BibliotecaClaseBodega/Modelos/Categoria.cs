using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClaseBodega.Modelos
{
    /// <summary>
    /// Tabla Categoria
    /// </summary>
    public class Categoria:BaseEntity
    {
        // campos
        [Required]
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        //relacion de 1 a muchos con productos
        public ICollection<Productos> Productos { get; set; }

        //constructor para la instancia de conexion
        public Categoria() : base()
        {
            this.Productos = new HashSet<Productos>();
        }
    }
}
