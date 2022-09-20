using System.Collections.Generic;
using CuidadoEquino.App.Dominio;

namespace CuidadoEquino.App.Persistencia
{
    public interface IRepositorioIndicadoresdeSalud
    {
        IEnumerable<IndicadoresdeSalud> GetAllIndicadoresdeSalud();
        IndicadoresdeSalud AddIndicadoresdeSalud (IndicadoresdeSalud indicadoresdeSalud);
        IndicadoresdeSalud UpdateIndicadoresdeSalud(IndicadoresdeSalud indicadoresdeSalud);
        void DeleteIndicadoresdeSalud(int IdIndicadoresdeSalud);
        IndicadoresdeSalud GetIndicadoresdeSalud(int IdIndicadoresdeSalud);
    }  

 }



