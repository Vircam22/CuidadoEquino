using System;

namespace CuidadoEquino.App.Dominio
{
    public class IndicadoresdeSalud
    {
        public int Id {get; set;}
        public int Id_Caballo_Veterinario {get; set;}
        public string Temperatura {get; set;}
        public int Peso {get; set;}
        public string Frecuencia_Respiratoria {get; set;}
        public string Frecuencia_Cardiaca {get; set;}
        public string EstadodeAnimo {get; set;}
        public string FechaVisita {get; set;}
        public string Recomendaciones {get; set;}
        public string Medicamentos {get; set;}
    }
}