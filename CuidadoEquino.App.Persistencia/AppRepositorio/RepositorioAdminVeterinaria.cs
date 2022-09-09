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
        Caballo IRepositorioAdminVeterinaria.AddAdminVeterinaria(AdminVeterinaria adminVeterinaria)
        {
            var adminVeterinariaAdicionado = _appContext.AdminVeterinarias.add(adminVeterinaria);
            _appContext.SaveChanges();
            return adminVeterinariaAdicionado.Entity;
        }
        void IRepositorioAdminVeterinaria.DeleteAdminVeterinaria(int idAdminVeterinaria)
        {
            var adminVeterinariaEncontrado = _appContext.AdminVeterinaria.FirstOrDefault(c => c.Id == idAdminVeterinaria);
            if (caballoEncontrado == null)
                return;
            _appContext.AdminVeterinarias.Remove(adminVeterinariaEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<AdminVeterinaria> IRepositorioAdminVeterinaria.GetAllAdminVeterinarias()
        {
            return _appContext.AdminVeterinaria;
        }

        AdminVeterinaria IRepositorioAdminVeterinaria.GetAdminVeterinaria(int idAdminVeterinaria)
        {
            return _appContext.AdminVeterinarias.FirstOrDefault(adminVeterinariaEncontrado => c.Id == idAdminVeterinaria);
        }

        AAdminVeterinaria IRepositorioAdminVeterinaria.UpdateAdminVeterinaria(AdminVeterinaria adminVeterinaria)
        {
            var adminVeterinariaEncontrado = _appContext.AdminVeterinarias.FirstOrDefault(adminVeterinariaEncontrado => c.Id == adminVeterinaria.Id);
            if (caballoEncontrado != null)
            {
                adminVterinariaEncontrado.Id = adminVeterinaria.Id;
                adminVeterinariaEncontrado.Nombre = adminVeterinaria.Nombre;
                
                _appContext.SaveChanges();

            }
            return adminVterinariaEncontrado;
        }
    }
}
