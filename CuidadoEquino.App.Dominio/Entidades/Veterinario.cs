using System;

namespace CuidadoEquino.App.Dominio
{
    public class Veterinario
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellidos {get; set;}
        public string Direccion {get; set;}
        public string Telefono {get; set;}
        public int Tarjeta_Profesional {get; set;}
    }
}