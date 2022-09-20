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
        
        public HistoriaClinica AddHistoriaClinica(HistoriaClinica historiaClinica)
        {
            var historiaClinicaAdicionada = _appContext.HistoriasClinicas.Add(historiaClinica);
            _appContext.SaveChanges();
            return historiaClinicaAdicionada.Entity;
        }
        
        public void DeleteHistoriaClinica(int idHistoriaClinica)
        {
            var historiaClinicaEncontrada = _appContext.HistoriasClinicas.FirstOrDefault(c => c.Id == idHistoriaClinica);
            if (historiaClinicaEncontrada == null)
                return;
            _appContext.HistoriasClinicas.Remove(historiaClinicaEncontrada);
            _appContext.SaveChanges();

        }

        public IEnumerable<HistoriaClinica> GetAllHistoriasClinicas()
        {
            return _appContext.HistoriasClinicas;
        }

        public HistoriaClinica GetHistoriaClinica(int idHistoriaClinica)
        {
            return _appContext.HistoriasClinicas.FirstOrDefault(historiaClinicaEncontrado => historiaClinicaEncontrado.Id == idHistoriaClinica);
        }

        public HistoriaClinica UpdateHistoriaClinica(HistoriaClinica historiaClinica)
        {
            var historiaClinicaEncontrada = _appContext.HistoriasClinicas.FirstOrDefault(historiaClinicaEncontrada => historiaClinicaEncontrada.Id == historiaClinica.Id);
            if (historiaClinicaEncontrada != null)
            {
                historiaClinicaEncontrada.Id_Caballo = historiaClinica.Id_Caballo;
                historiaClinicaEncontrada.IdIndicadoresdeSalud = historiaClinica.IdIndicadoresdeSalud;
                historiaClinicaEncontrada.FechaApertura = historiaClinica.FechaApertura;
                
                _appContext.SaveChanges();

            }
            return historiaClinicaEncontrada;
        }
    }
}
