using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClaseBodega.Modelos
{
    /// <summary>
    /// Defino los campos que debe contenar la tabla por defecto
    /// Id --> Es un identity PK
    /// DiaDeCreacion --> Campo que tendra la fecha de creación de un registro
    /// -------
    /// Le Creo un Constructor el cual genere de manera automática la fecha del sistema actual cuando se agrega el registro
    /// eso para el campo DiaDeCreacion
    /// </summary>
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DiaDeCreacion { get; set; }

        public BaseEntity()
        {
            this.DiaDeCreacion = DateTime.Now;
        }
    }
}
