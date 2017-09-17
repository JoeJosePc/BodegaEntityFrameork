using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClaseBodega.Contextos;
using BibliotecaClaseBodega.Modelos;

namespace ConsolaDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            // creo el objeto Bodega y producto
            Bodega bodega = new Bodega();
            Productos nuevoProducto = new Productos();
            nuevoProducto.Nombre = "Sporade 400ml";
            nuevoProducto.Marca = "Aje";
            nuevoProducto.Categoria = "Rehidratante";
            nuevoProducto.Estado = true;
            bodega.Productos.Add(nuevoProducto);
            bodega.SaveChanges();
        }
    }
}
