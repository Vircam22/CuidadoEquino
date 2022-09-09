using System;

namespace CuidadoEquino.App.Dominio
{
    public class HistoriaClinica
    {
        public int Id {get; set;}
        public int IdIndicadoresdeSalud {get;set;}
        public string FechaApertura {get; set;}
        public int Id_Caballo {get; set;}
    }
}