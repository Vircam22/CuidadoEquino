using System.Collections.Generic;
using CuidadoEquino.App.Dominio;

namespace CuidadoEquino.App.Persistencia
{
    public interface IRepositorioCaballo_Veterinario
    {
        IEnumerable<Caballo_Veterinario> GetAllCaballo_Veterinario();
        Caballo_Veterinario AddCaballo_Veterinario(Caballo_Veterinario caballo_Veterinario);
        Caballo_Veterinario UpdateCaballo_Veterinario(Caballo_Veterinario caballo_Veterinario);
        void DeleteCaballo_Veterinario(int IdCaballo_Veterinario);
        Caballo_Veterinario GetCaballo_Veterinario(int IdCaballo_Veterinario);
    }  

 }



