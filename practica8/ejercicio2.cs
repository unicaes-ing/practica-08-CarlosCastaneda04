using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica8
    //
{
    class ejercicio2
    {
        public struct Producto
        {
            public string nombre;
            private int cantidad;
            private double precio;
            private const double iva = 0.13;

            public void setCantidad(int cant)
            {
                if (cant > 0)
                {
                    this.cantidad = cant;
                }
            }

            public int getCantidad()
            {
                return cantidad;
            }

            public void setPrecio(double precio)
            {
                if (precio > 0.00)
                {
                    this.precio = precio;
                }
            }

            public double getPrecio()
            {
                double pago;
                pago = precio + iva;
                return precio + pago;
            }
        }

        static void Main(string[] args)
        {
            int cant;
            Console.WriteLine("Ingrese la cantidad de productos: ");
            cant = int.Parse(Console.ReadLine());
            Producto[] producto = new Producto[cant];
            for (int i = 0; i < producto.Length; i++)
            {
                Console.WriteLine("Producto #{0}", i + 1);
                Console.WriteLine("Ingrese el nombre del producto: ");
                producto[i].nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad del producto: ");
                producto[i].setCantidad(int.Parse(Console.ReadLine()));
                Console.WriteLine("Ingrese el precio del producto: ");
                producto[i].setPrecio(double.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < producto.Length; i++)
            {
                double total;
                total = producto[i].getCantidad() * producto[i].getPrecio();
                Console.Clear();
                Console.WriteLine("Nombre del producto: {0}", producto[i].nombre);
                Console.WriteLine("Cantidad del producto: {0}", producto[i].getCantidad());
                Console.WriteLine("Precio del producto: {0}", producto[i].getPrecio());
                Console.WriteLine("Total: ", total);
            }
            Console.ReadKey();
        }
    }
}
