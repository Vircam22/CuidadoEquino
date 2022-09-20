using System.Collections.Generic;
using System.Linq;
using CuidadoEquino.App.Dominio;


namespace CuidadoEquino.App.Persistencia
{
    public class RepositorioAdminVeterinaria : IRepositorioAdminVeterinaria
    {
        private readonly AppContext _appContext;

        public RepositorioAdminVeterinaria(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        public AdminVeterinaria AddAdminVeterinaria(AdminVeterinaria adminVeterinaria)
        {
            var adminVeterinariaAdicionado = _appContext.AdminVeterinarias.Add(adminVeterinaria);
            _appContext.SaveChanges();
            return adminVeterinariaAdicionado.Entity;
        }
        public void DeleteAdminVeterinaria(int idAdminVeterinaria)
        {
            var adminVeterinariaEncontrado = _appContext.AdminVeterinarias.FirstOrDefault(c => c.Id == idAdminVeterinaria);
            if (adminVeterinariaEncontrado == null)
                return;
            _appContext.AdminVeterinarias.Remove(adminVeterinariaEncontrado);
            _appContext.SaveChanges();

        }

        public IEnumerable<AdminVeterinaria> GetAllAdminVeterinaria()
        {
            return _appContext.AdminVeterinarias;
        }

        public AdminVeterinaria GetAdminVeterinaria(int idAdminVeterinaria)
        {
            return _appContext.AdminVeterinarias.FirstOrDefault(adminVeterinariaEncontrado => adminVeterinariaEncontrado.Id == idAdminVeterinaria);
        }

        public AdminVeterinaria UpdateAdminVeterinaria(AdminVeterinaria adminVeterinaria)
        {
            var adminVeterinariaEncontrado = _appContext.AdminVeterinarias.FirstOrDefault(adminVeterinariaEncontrado => adminVeterinariaEncontrado.Id == adminVeterinaria.Id);
            if (adminVeterinariaEncontrado != null)
            {
                adminVeterinariaEncontrado.Id = adminVeterinaria.Id;
                adminVeterinariaEncontrado.Nombre = adminVeterinaria.Nombre;

                _appContext.SaveChanges();
            }
            return adminVeterinariaEncontrado;
        }
    }
}
