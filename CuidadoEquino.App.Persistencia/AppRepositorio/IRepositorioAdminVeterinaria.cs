using System.Collections.Generic;
using CuidadoEquino.App.Dominio;

namespace CuidadoEquino.App.Persistencia
{
    public interface IRepositorioAdminVeterinaria
    {
        IEnumerable<AdminVeterinaria> GetAllAdminVeterinaria();
        AdminVeterinaria AddAdminVeterinaria(AdminVeterinaria adminVeterinaria);
        AdminVeterinaria UpdateAdminVeterinaria(AdminVeterinaria adminVeterinaria);
        void DeleteAdminVeterinaria(int idAdminVeterinaria);
        AdminVeterinaria GetAdminVeterinaria(int idAdminVeterinaria);
    }  

 }


