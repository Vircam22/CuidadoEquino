using System.Collections.Generic;
using System.Linq;
using CuidadoEquino.App.Dominio;


namespace CuidadoEquino.App.Persistencia
{
    public class RepositorioHistoriaClinica : IRepositorioHistoriaClinica
    {
        private readonly AppContext _appContext;

        public RepositorioHistoriaClinica(AppContext appContext)
        {
            _appContext = appContext;
        }
        Caballo IRepositorioHistoriaClinica.AddHistoriaClinica(HistoriaClinica historiaClinica)
        {
            var historiaClinicaAdicionada = _appContext.HistoriaClinica.add(historiaClinica);
            _appContext.SaveChanges();
            return historiaClincaAdicionada.Entity;
        }
        void IRepositorioHistoriaClinica.DeleteHistoriaClinica(int idHistoriaClinica)
        {
            var historiaClinicaEncontrada = _appContext.HistoriasClinicas.FirstOrDefault(c => c.Id == idCaballo);
            if (caballoEncontrado == null)
                return;
            _appContext.HistoriasClinicas.Remove(historiaClinicaEncontrada);
            _appContext.SaveChanges();

        }

        IEnumerable<HistoriaClinica> IRepositorioHistoriaClinica.GetAllHistoriasClinicas()
        {
            return _appContext.HistoriaClinica;
        }

        Caballo IRepositorioHistoriaClinica.GetHistoriaClinica(int idHistoriaClinica)
        {
            return _appContext.HistoriasClinicas.FirstOrDefault(historiaClinicaEncontrado => c.Id == idHistoriaClinica);
        }

        Caballo IRepositorioHistoriaClinica.UpdateHistoriaClinica(HistoriaClinica historiaClinica)
        {
            var historiaClinicaEncontrada = _appContext.HistoriasClinicas.FirstOrDefault(historiaClinicaEncontrada => c.Id == historiaClinica.Id);
            if (historiaClinicaEncontrada != null)
            {
                historiaClinicaEncontrada.IdCaballo = historiaClinica.IdCaballo;
                historiaClinicaEncontrada.IdIndicadoresdeSalud = historiaClinica.IdIndicadoresdeSalud;
                historiaClinicaEncontrado.FechaVisita = historiaClinica.FechaVisita;
                
                _appContext.SaveChanges();

            }
            return historiaClinicaEncontrada;
        }
    }
}
