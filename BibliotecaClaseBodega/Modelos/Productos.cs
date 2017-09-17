using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Required]
        public string Nombre { get; set; }
        public DateTime? FechaVence { get; set; } //agrego
        public bool Estado { get; set; }

        //relacion de 1 a muchos
        //seteo el FK
        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

        //relacion de 1 a muchos
        //seteo el FK
        [ForeignKey("Marca")]
        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }
    }
}
