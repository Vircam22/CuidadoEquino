using System.Collections.Generic;
using System.Linq;
using CuidadoEquino.App.Dominio;


namespace CuidadoEquino.App.Persistencia
{
    public class RepositorioCaballo_Veterinario : IRepositorioCaballo_Veterinario
    {
        private readonly AppContext _appContext;

        public RepositorioCaballo_Veterinario(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Caballo_Veterinario AddCaballo_Veterinario(Caballo_Veterinario caballo_Veterinario)
        {
            var caballo_VeterinarioAdicionado = _appContext.Caballos_Veterinarios.Add(caballo_Veterinario);
            _appContext.SaveChanges();
            return caballo_VeterinarioAdicionado.Entity;
        }

        public void DeleteCaballo_Veterinario(int IdCaballo_Veterinario)
        {
            var caballo_VeterinarioEncontrado = _appContext.Caballos_Veterinarios.FirstOrDefault(c => c.Id == IdCaballo_Veterinario);
            if (caballo_VeterinarioEncontrado == null)
                return;
            _appContext.Caballos_Veterinarios.Remove(caballo_VeterinarioEncontrado);
            _appContext.SaveChanges();

        }

        public IEnumerable<Caballo_Veterinario> GetAllCaballo_Veterinario()
        {
            return _appContext.Caballos_Veterinarios;
        }

        public Caballo_Veterinario GetCaballo_Veterinario(int Id_Caballo_Veterinario)
        {
            return _appContext.Caballos_Veterinarios.FirstOrDefault(caballo_VeterinarioEncontrado => caballo_VeterinarioEncontrado.Id == Id_Caballo_Veterinario);
        }

        public Caballo_Veterinario UpdateCaballo_Veterinario(Caballo_Veterinario caballo_Veterinario)
        {
            var caballo_VeterinarioEncontrado = _appContext.Caballos_Veterinarios.FirstOrDefault(caballo_VeterinarioEncontrado => caballo_VeterinarioEncontrado.Id == caballo_Veterinario.Id);
            if (caballo_VeterinarioEncontrado != null)
            {
                caballo_VeterinarioEncontrado.Fecha_asignado = caballo_Veterinario.Fecha_asignado;
                ///acá no sé si tengo que repetir los id veterinario y id caballo
                caballo_VeterinarioEncontrado.Id_Caballo = caballo_Veterinario.Id_Caballo;
                caballo_VeterinarioEncontrado.Id_Veteinario = caballo_Veterinario.Id_Veteinario;

                _appContext.SaveChanges();

            }
            return caballo_VeterinarioEncontrado;
        }
    }
}
