using System;
using System.Collections.Generic;
using CuidadoEquino.App.Dominio;

namespace CuidadoEquino.App.Persistencia
{
    public class CaballoRepositorio : ICaballoRepositorio
    {
        private readonly AppContext _context;

        public CaballoRepositorio()
        {
            _context = new AppContext();
        }

        public IEnumerable<Caballo> ObtenerTodos()
        {
            return _context.Caballos.ToList();
        }

        public void Insertar(Caballo caballo)
        {
            _context.Caballos.Add(caballo);
            _context.SaveChanges();
        }
    }
}