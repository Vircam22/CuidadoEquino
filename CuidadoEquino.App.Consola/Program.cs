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

            using(var context = new Persistencia.AppContext())
            {
                var caballo = new Caballo()
                {
                    Nombre = "Rocky",
                    Color = "Gris",
                    Especie = "Pony",
                    Raza = "Manso"
                };
                context.Caballos.Add(caballo);
                context.SaveChanges();
            }
        }
    }
}
