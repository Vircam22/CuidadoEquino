using System.Collections.Generic;
using CuidadoEquino.App.Dominio;

namespace CuidadoEquino.App.Persistencia
{
    public interface IRepositorioHistoriaClinica
    {
        IEnumerable<HistoriaClinica> GetAllHistoriasClinicas();
        HistoriaClinica AddHistoriaClinica(HistoriaClinica historiaClinica);
        HistoriaClinica UpdateHistoriaClinica(HistoriaClinica historiaClinica);
        void DeleteHistoriaClinica(int idHistoriaClinica);
        HistoriaClinica GetHistoriaClinica(int idHistoriaClinica);
    }  

 }



