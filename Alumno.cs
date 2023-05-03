using System;

namespace Listas_2023_II
{
    internal class Alumno
    {
        private string nombre;
        private string numeroCuenta;

        public Alumno(string nombre, string numeroCuenta)
        {
            Nombre = nombre;
            NumeroCuenta = numeroCuenta;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
    }
}
