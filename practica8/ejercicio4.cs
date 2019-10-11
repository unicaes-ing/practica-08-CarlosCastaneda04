using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica8
{
    class ejercicio4
    {
        public enum TipoDePago
        {
            Efectivo = 10,
            TarjetaDeDebito = 20,
            TarjetaDeCredito = 30,
        }

        static void Main(string[] args)
        {
            double ingresado;
            Console.WriteLine("Ingrese el total a pagar: ");
            ingresado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de pago: ");
            Console.WriteLine(" [1].Efectivo");
            Console.WriteLine(" [2].Tarjeta de Debito");
            Console.WriteLine(" [3].Tarjeta de Credito");
            Console.WriteLine("***************************");
            int tipo = Convert.ToInt32(Console.ReadLine());
            switch ((TipoDePago)tipo)
            {
                case TipoDePago.Efectivo:
                    Console.Clear();
                    Console.WriteLine("Monto:${0}", ingresado);
                    Console.WriteLine("Efectivo: Descuento del 15%");
                    double total1, sub1;
                    sub1 = ingresado * 0.15;
                    total1 = ingresado - sub1;
                    Console.WriteLine("El total es de:${0}", total1);

                    break;

                case TipoDePago.TarjetaDeDebito:
                    Console.Clear();
                    Console.WriteLine("Monto:${0}", ingresado);
                    Console.WriteLine("Tarjeta de Debito: Descuento del 10%");

                    double total2, sub2;
                    sub2 = ingresado * 0.10;
                    total2 = ingresado - sub2;
                    Console.WriteLine("El total es de:${0}", total2);
                    break;

                case TipoDePago.TarjetaDeCredito:
                    Console.Clear();
                    Console.WriteLine("Monto:${0}", ingresado);
                    Console.WriteLine(" Tarjeta de Credito: Descuento del 5%");
                    double total3, sub3;
                    sub3 = ingresado * 0.05;
                    total3 = ingresado - sub3;
                    Console.WriteLine("El total es de:${0}", total3);

                    break;




            }
            Console.ReadKey();
        }
    }
}
