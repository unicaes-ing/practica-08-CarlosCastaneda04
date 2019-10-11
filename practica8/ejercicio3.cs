using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica8
{
    class ejercicio3
    {
        public struct materia
        {
            public string nombre;
            private double nota;

            public void setNota(double nota)
            {
                if (nota <= 6.0)
                {
                    this.nota = nota;
                }
                else
                {
                    this.nota = nota;
                }
            }

            public double getNota()
            {
                if (nota <= 6.0)
                {
                    Console.WriteLine("Reprobado");
                }
                else
                {
                    Console.WriteLine("Aprobado");
                }
                return nota;
            }
        }

        public struct Alumno
        {
            public string carnet;
            public string nombre;
            public string carrera;
            public materia materia1;
            public materia materia2;
            public materia materia3;
            public materia materia4;
        }

        static void Main(string[] args)
        {
            int cantidad;
            Console.WriteLine("Cantidad de alumnos: ");
            cantidad = int.Parse(Console.ReadLine());
            Alumno[] estudiante = new Alumno[cantidad];
            for (int i = 0; i < estudiante.Length; i++)
            {
                Console.WriteLine("Alumno #{0}: ", i + 1);
                Console.WriteLine("Ingrese el carnet del alumno: ");
                estudiante[i].carnet = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del alumno: ");
                estudiante[i].nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la carrera del alumno: ");
                estudiante[i].carrera = Console.ReadLine();
                Console.WriteLine("Nota de la primera materia: ");
                estudiante[i].materia1.setNota(double.Parse(Console.ReadLine()));
                Console.WriteLine("Nota de 2da materia: ");
                estudiante[i].materia2.setNota(double.Parse(Console.ReadLine()));
                Console.WriteLine("Nota de 3ra materia: ");
                estudiante[i].materia3.setNota(double.Parse(Console.ReadLine()));
                Console.WriteLine("Nota de 4ta materia: ");
                estudiante[i].materia4.setNota(double.Parse(Console.ReadLine()));
            }
            Console.Clear();
            int n = 0;
            foreach (Alumno x in estudiante)
            {
                n++;
                Console.WriteLine("Alumno #{0}", n);
                Console.WriteLine("Carnet: {0}", x.carnet);
                Console.WriteLine("Nombre: {0}", x.nombre);
                Console.WriteLine("Carrera: {0}", x.carrera);
                Console.WriteLine("Materia reprobadas y aprobadas: ");
                Console.WriteLine("1a materia: {0}", x.materia1.getNota());
                Console.WriteLine("2da materia: {0}", x.materia2.getNota());
                Console.WriteLine("3ra materia: {0}", x.materia3.getNota());
                Console.WriteLine("4ta materia: {0}", x.materia4.getNota());
            }
            Console.ReadKey();
        }
    }
}
