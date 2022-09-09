using System.Collections.Generic;
using System.Linq;
using CuidadoEquino.App.Dominio;


namespace CuidadoEquino.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        private readonly AppContext _appContext;

        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }
        Caballo IRepositorioVeterinario.AddPropietario(Veterinario veterinario)
        {
            var veterinarioAdicionado = _appContext.Veterinarios.add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }
        void IRepositorioVeterinario.DeletVeterinario(int idVeterinario)
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(c => c.Id == idVeterinario);
            if (veterinarioEncontrado == null)
                return;
            _appContext.Veterinarios.Remove(veterinarioEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<Propietario> IRepositorioVeterinario.GetAllVeterinarios()
        {
            return _appContext.Veterinarios;
        }

        Veterinario IRepositorioVeterinario.GetVeterinario(int idVeterinario)
        {
            return _appContext.Veterinarios.FirstOrDefault(veterinarioEncontrado => c.Id == idVeterinario);
        }

        Propietario IRepositorioVeterinario.UpdateVeterinario(Veterinario veterinario)
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(veterinarioEncontrado => c.Id == veterinario.Id);
            if (veterinarioEncontrado != null)
            {
                veterianrioEncontrado.Id = veterinario.Id;
                veterinarioEncontrado.Nombre = veterinario.Nombre;
                veterinarioEncontrado.Apellidos = veterinario.Apellidos;
                veterinarioEncontrado.Dirección = veterinario.Dirección;
                veterinarioEncontrado.Teléfono = veterinario.Teléfono;
                veterinarioEncontrado.Tarjeta_Profesional = veterinario.Tarjeta_Profesional;


                _appContext.SaveChanges();

            }
            return veterinarioEncontrado;
        }
    }
}


