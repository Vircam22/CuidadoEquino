using System.Collections.Generic;
using CuidadoEquino.App.Dominio;

namespace CuidadoEquino.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAllVeterinarios();
        Veterinario AddVeterinario(Veterinario veterinario);
        Veterinario UpdateVeterinario(Veterinario veterinario);
        void DeletVeterinario(int idVeterinario);
        Propietario GetVeterinario(int idVeterinario);
    }
}
