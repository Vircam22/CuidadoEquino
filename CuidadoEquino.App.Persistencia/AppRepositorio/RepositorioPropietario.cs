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
        
        public Propietario AddPropietario(Propietario propietario)
        {
            var propietarioAdicionado = _appContext.Propietarios.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;
        }
        
        public void DeletePropietario(int idPropietario)
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(c => c.Id == idPropietario);
            if (propietarioEncontrado == null)
                return;
            _appContext.Propietarios.Remove(propietarioEncontrado);
            _appContext.SaveChanges();

        }

        public IEnumerable<Propietario> GetAllPropietarios()
        {
            return _appContext.Propietarios;
        }

        public Propietario GetPropietario(int idPropietario)
        {
            return _appContext.Propietarios.FirstOrDefault(propietarioEncontrado => propietarioEncontrado.Id == idPropietario);
        }

        public Propietario UpdatePropietario(Propietario propietario)
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(propietarioEncontrado => propietarioEncontrado.Id == propietario.Id);
            if (propietarioEncontrado != null)
            {
                propietarioEncontrado.Id = propietario.Id;
                propietarioEncontrado.Nombre = propietario.Nombre;
                propietarioEncontrado.Apellidos = propietario.Apellidos;
                propietarioEncontrado.Direccion = propietario.Direccion;
                propietarioEncontrado.Telefono = propietario.Telefono;
                propietarioEncontrado.Email = propietario.Email;
                
                _appContext.SaveChanges();
            }
            return propietarioEncontrado;
        }
    }
}


