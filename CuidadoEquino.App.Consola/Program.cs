using System;
using CuidadoEquino.App.Dominio;
using CuidadoEquino.App.Persistencia;

namespace CuidadoEquino.App.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            using (var context : new Persistencia.AppContext())
            {
                
            }
        }
    }
}
