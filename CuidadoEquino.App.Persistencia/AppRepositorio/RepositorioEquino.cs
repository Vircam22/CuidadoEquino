using System.Collections.Generic;
using System.Linq;
using CuidadoEquino.App.Dominio;


namespace CuidadoEquino.App.Persistencia
{
    public class RepositorioEquino : IRepositorioEquino
    {
        private readonly AppContext _appContext;

        public RepositorioEquino(AppContext appContext)
        {
            _appContext = appContext;
        }
        Caballo IRepositorioEquino.AddCaballo(Caballo caballo)
        {
            var caballoAdicionado = _appContext.Caballos.add(caballo);
            _appContext.SaveChanges();
            return caballoAdicionado.Entity;
        }
        void IRepositorioEquino.DeleteCaballo(int idCaballo)
        {
            var caballoEncontrado = _appContext.Caballos.FirstOrDefault(c => c.Id == idCaballo);
            if (caballoEncontrado == null)
                return;
            _appContext.Caballos.Remove(caballoEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<Caballo> IRepositorioEquino.GetAllCaballos()
        {
            return _appContext.Caballos;
        }

        Caballo IRepositorioEquino.GetCaballo(int idCaballo)
        {
            return _appContext.Caballos.FirstOrDefault(caballoEncontrado => c.Id == idCaballo);
        }

        Caballo IRepositorioEquino.UpdateCaballo(Caballo caballo)
        {
            var caballoEncontrado = _appContext.Caballos.FirstOrDefault(caballoEncontrado => c.Id == caballo.Id);
            if (caballoEncontrado != null)
            {
                caballoEncontrado.Nombre = caballo.Nombre;
                caballoEncontrado.Color = caballo.Color;
                caballoEncontrado.Especie = caballo.Especie;
                caballoEncontrado.Raza = caballo.Raza;
                caballoEncontrado.Propietario = caballo.Propietario;
                caballoEncontrado.Veterinario = caballo.Veterinario;
                caballoEncontrado.HistoriaClinica = caballo.HistoriaClinica;

                _appContext.SaveChanges();

            }
            return caballoEncontrado;
        }
    }
}
