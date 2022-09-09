using System.Collections.Generic;
using CuidadoEquino.App.Dominio;

namespace CuidadoEquino.App.Persistencia
{
    public interface IRepositorioAdminVeterinaria
    {
        IEnumerable<AdminVeterinaria> GetAllAdminVeterinarias();
        AdminVeterinaria AddAdminVeterinaria(AdminVeterinaria adminVeterinaria);
        AdminVeterinaria UpdateAdminVeterinaria(AdminVeterinaria adminVeterinaria);
        void DeletVeterinaria(int idAdminVeterinaria);
        AdminVeterinaria GetAdminVeterinaria(int idAdminVeterinaria);
    }  

 }


