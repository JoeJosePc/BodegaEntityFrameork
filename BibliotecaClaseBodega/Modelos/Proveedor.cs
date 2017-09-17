using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClaseBodega.Modelos
{
    public class Proveedor:BaseEntity
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Contacto { get; set; } //agregue
        public bool Estado { get; set; }

        public ICollection<Marca> Marcas { get; set; }

        public Proveedor() : base()
        {
            this.Marcas = new HashSet<Marca>();
        }
    }
}
