using System.Collections.Generic;
using CuidadoEquino.App.Dominio;

namespace CuidadoEquino.App.Persistencia
{
    public interface IRepositorioCaballo
    {
        IEnumerable<Caballo> GetAllCaballos();
        Caballo AddCaballo(Caballo caballo);
        Caballo UpdateCaballo(Caballo caballo);
        void DeleteCaballo(int idCaballo);
        Caballo GetCaballo(int idCaballo);
    }  

 }



