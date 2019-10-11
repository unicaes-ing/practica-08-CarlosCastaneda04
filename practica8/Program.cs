using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica8
{
    class Program
    {
        public struct Estudiante
        {
            public string carnet;
            public string nombre;
            public string carrera;
            private double cum;

            public void setCum(double cum)
            {
                if (cum >= 0)
                {
                    if (cum <= 10)
                    {
                        this.cum = cum;
                    }
                }
            }

            public double getCum()
            {
                return cum;
            }
        }

        static void Main(string[] args)
        {
            Estudiante alumno = new Estudiante();
            Console.WriteLine("Ingrese su carnet: ");
            alumno.carnet = Console.ReadLine();
            Console.WriteLine("Ingrese su nombre: ");
            alumno.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su carrera: ");
            alumno.carrera = Console.ReadLine();
            Console.WriteLine("Ingrese su cum: ");
            alumno.setCum(double.Parse(Console.ReadLine()));
            Console.Clear();
            Console.WriteLine("Carnet: {0}", alumno.carnet);
            Console.WriteLine("Nombre: {0}", alumno.nombre);
            Console.WriteLine("Carrera: {0}", alumno.carrera);
            Console.WriteLine("CUM: {0}", alumno.getCum());
        }
    }
}
