using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Producto prod1 = new Producto(1, "1A", "Coca", 56.12f);
                Producto prod2 = new Producto(2, "1B", "Pepsi", 156.12f);
                Producto prod3 = new Producto(3, "1C", "Manaos", 256.12f);
                Producto prod4 = new Producto(4, "1D", "Fanta", 36.12f);
                ProductosDAO productosDAO = new ProductosDAO();
                //productosDAO.InsertarProducto(prod1);
                //productosDAO.InsertarProducto(prod2);
                //productosDAO.InsertarProducto(prod3);
                //productosDAO.InsertarProducto(prod4);
                //productosDAO.EliminarProductoPorId(3);
                //productosDAO.ModificarProducto(new Producto(1, "1E", "Paso", 156.12f));

                List<Producto> productos = productosDAO.ListarProductos();

                foreach(Producto p in productos)
                {
                    Console.WriteLine($"id: {p.Id} nombre: {p.Nombre} precio: {p.Precio}");
                }

                Producto nuevo = productosDAO.ListarPorId(2);
                Console.WriteLine($"id: {nuevo.Id} nombre: {nuevo.Nombre} precio: {nuevo.Precio}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
