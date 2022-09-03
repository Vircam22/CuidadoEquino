using System;
namespace CuidadoEquino.App.Dominio;

public class HistoriaClinica:IndicadoresdeSalud
{
    public int IdCaballo {get; set;}
    public string FechaVisita {get; set;}
}