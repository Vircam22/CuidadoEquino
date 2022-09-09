using System.Collections.Generic;
using System.Linq;
using CuidadoEquino.App.Dominio;


namespace CuidadoEquino.App.Persistencia
{
    public class RepositorioPropietario : IRepositorioPropietario
    {
        private readonly AppContext _appContext;

        public RepositorioPropietario(AppContext appContext)
        {
            _appContext = appContext;
        }
        Caballo IRepositorioPropietario.AddPropietario(Propietario propietario)
        {
            var propietarioAdicionado = _appContext.Propietarios.add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;
        }
        void IRepositorioPropietario.DeletPropietario(int idPropietario)
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(c => c.Id == idPropietario);
            if (propietarioEncontrado == null)
                return;
            _appContext.Propietarios.Remove(propietarioEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<Propietario> IRepositorioPropietario.GetAllPropietarios()
        {
            return _appContext.Propietarios;
        }

        Caballo IRepositorioPropietario.GetPropietario(int idPropietario)
        {
            return _appContext.Caballos.FirstOrDefault(propietarioEncontrado => c.Id == idPropietario);
        }

        Propietario IRepositorioPropietario.UpdatePropietario(Propietario propietario)
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(propietarioEncontrado => c.Id == propietario.Id);
            if (caballoEncontrado != null)
            {
                pacienteEncontrado.Id = propietario.Id;
                propietarioEncontrado.Nombre = propietario.Nombre;
                proietarioEncontrado.Apellidos = propietario.Apellidos;
                propietarioEncontrado.Dirección = propietario.Dirección;
                propietarioEncontrado.Teléfono = propietario.Teléfono;
                propietarioEncontrado.Correo = propietario.Correo;
                

                _appContext.SaveChanges();

            }
            return propietarioEncontrado;
        }
    }
}


