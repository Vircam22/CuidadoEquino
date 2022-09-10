using System;
using System.Collections.Generic;
using CuidadoEquino.App.Dominio;

namespace CuidadoEquino.App.Persistencia
{
    public interface ICaballoRepositorio
    {
        IEnumerable<Caballo> ObtenerTodos();
        //Caballo ObtenerPorId(int IdCaballo);

        void Insertar(Caballo caballo);
    }
}