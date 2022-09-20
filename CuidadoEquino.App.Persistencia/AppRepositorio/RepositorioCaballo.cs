using System.Collections.Generic;
using System.Linq;
using CuidadoEquino.App.Dominio;


namespace CuidadoEquino.App.Persistencia
{
    public class RepositorioCaballo : IRepositorioCaballo
    {
        private readonly AppContext _appContext;

        public RepositorioCaballo(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        public Caballo AddCaballo(Caballo caballo)
        {
            var caballoAdicionado = _appContext.Caballos.Add(caballo);
            _appContext.SaveChanges();
            return caballoAdicionado.Entity;
        }
        
        public void DeleteCaballo(int idCaballo)
        {
            var caballoEncontrado = _appContext.Caballos.FirstOrDefault(c => c.Id == idCaballo);
            if (caballoEncontrado == null)
                return;
            _appContext.Caballos.Remove(caballoEncontrado);
            _appContext.SaveChanges();

        }

        public IEnumerable<Caballo> GetAllCaballos()
        {
            return _appContext.Caballos;
        }

        public Caballo GetCaballo(int idCaballo)
        {
            return _appContext.Caballos.FirstOrDefault(caballoEncontrado => caballoEncontrado.Id == idCaballo);
        }

        public Caballo UpdateCaballo(Caballo caballo)
        {
            var caballoEncontrado = _appContext.Caballos.FirstOrDefault(caballoEncontrado => caballoEncontrado.Id == caballo.Id);
            if (caballoEncontrado != null)
            {
                caballoEncontrado.Nombre = caballo.Nombre;
                caballoEncontrado.Color = caballo.Color;
                caballoEncontrado.Especie = caballo.Especie;
                caballoEncontrado.Raza = caballo.Raza;                
                _appContext.SaveChanges();
            }
            return caballoEncontrado;
        }
    }
}
