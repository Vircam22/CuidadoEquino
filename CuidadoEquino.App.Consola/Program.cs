using System;
using CuidadoEquino.App.Dominio;
using CuidadoEquino.App.Persistencia;

namespace CuidadoEquino.App.Consola
{
    class Program
    {

        private static ICaballoRepositorio _caballoRepositorio;

        static void Main(string[] args)
        {
            Console.WriteLine("Hola");
            _caballoRepositorio = new CaballoRepositorio();
            var caballo = new Caballo()
                {
                    Nombre = "Jorge",
                    Color = "Blanco",
                    Especie = "Brioso",
                    Raza = "Brioso"
                };
            _caballoRepositorio.Insertar(caballo);

        }
    }
}
