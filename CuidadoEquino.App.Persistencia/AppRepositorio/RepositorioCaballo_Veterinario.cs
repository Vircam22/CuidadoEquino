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
        Caballo IRepositorioCaballo_Veterinario.AddCaballo_Veterinario(Caballo_Veterinario caballo_Veterinario)
        {
            var caballo_VeterinarioAdicionado = _appContext.Caballos_Veterinarios.add(caballo_Veterinario);
            _appContext.SaveChanges();
            return caballo_VeterinarioAdicionado.Entity;
        }
        void IRepositorioCaballo_Veterinario.DeleteCaballo_Veterinario(int idCaballo_Veterinario)
        {
            var caballo_VeterinarioEncontrado = _appContext.Caballos_Veterinarios.FirstOrDefault(c => c.Id == idCaballo);
            if (caballo_VeterinarioEncontrado == null)
                return;
            _appContext.Caballos_Veterinarios.Remove(caballo_VeterinarioEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<Caballo> IRepositorioCaballo_Veterinario.GetAllCaballos_Veterinarios()
        {
            return _appContext.Caballos_Veterinarios;
        }

        Caballo IRepositorioCaballo_Veterinario.GetCaballo_Veterinario(int Id_Caballo_Veterinario)
        {
            return _appContext.Caballos_Veterinarios.FirstOrDefault(caballo_VeterinarioEncontrado => c_V.Id == Id_Caballo_Veterinario);
        }

        Caballo_Veterinario IRepositorioCaballo_Veterinario.UpdateCaballo_Veterinario(Id_Caballo_Veterinario caballo_Veterinario)
        {
            var caballo_VeterinarioEncontrado = _appContext.Caballos_Veterinarios.FirstOrDefault(caballo_VeterinarioEncontrado => c_V.Id == caballo_Veterinario.Id);
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
