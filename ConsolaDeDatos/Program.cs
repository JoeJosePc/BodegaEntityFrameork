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
            //Agrego proveedor
            Proveedor proveedor = new Proveedor();
            proveedor.Nombre = "Alicorp SAC";
            proveedor.Direccion = "Av. Argentina S/N";
            proveedor.Telefono = "1234567";
            proveedor.Email = "ventas@alicorp.pe";
            proveedor.Contacto = "Jose Alarcon";
            proveedor.Estado = true;
            //Agrego Marca
            Marca marca = new Marca();
            marca.Nombre = "Bolivar";
            marca.Estado = true;
            proveedor.Marcas.Add(marca);
            //Agrego Categoria
            Categoria categoria = new Categoria();
            categoria.Nombre = "Detergente";
            categoria.Estado = true;
            bodega.Categorias.Add(categoria);
            //Agrego Producto
            Productos producto = new Productos();
            producto.Nombre = "Jabon Barra";
            producto.FechaVence = DateTime.Now;
            producto.Estado = true;
            categoria.Productos.Add(producto);

            bodega.Proveedores.Add(proveedor);
            bodega.SaveChanges();
        }
    }
}
