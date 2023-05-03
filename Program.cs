using System;
using System.Collections.Generic;

namespace Listas_2023_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>();
            alumnos.Add(new Alumno("Jose","40220222"));
            alumnos.Add(new Alumno("Juan", "90222232"));
            alumnos.RemoveAt(0);

            foreach(Alumno alumno in alumnos)
            {
               Console.WriteLine("Nombre: {0} \n Número de Cuenta: {1} ",alumno.Nombre,alumno.NumeroCuenta);
            }

            Console.ReadLine();

        }
    }
}
