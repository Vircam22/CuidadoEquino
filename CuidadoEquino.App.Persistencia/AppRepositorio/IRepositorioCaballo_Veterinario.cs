using System.Collections.Generic;
using CuidadoEquino.App.Dominio;

namespace CuidadoEquino.App.Persistencia
{
    public interface IRepositorioCaballo_Veterinario
    {
        IEnumerable<Caballo_Veterinario> GetAllCaballo_Veterinario();
        IndicadoresdeSalud AddCaballo_Veterinario (Caballo_Veterinario caballo_Veterinario);
        IndicadoresdeSalud UpdateCaballo_Veterinario(Caballo_Veterinario caballo_Veterinario);
        void DeleteCaballo_Veterinario(int IdCaballo_Veterinario);
        IndicadoresdeSalud GetCaballo_Veterinariod(int IdCaballo_Veterinario);
    }  

 }



