using System.Collections.Generic;
using System.Linq;
using CuidadoEquino.App.Dominio;


namespace CuidadoEquino.App.Persistencia
{
    public class RepositorioIndicadoresdeSalud : IRepositorioIndicadoresdeSalud
    {

        private readonly AppContext _appContext;

        public RepositorioIndicadoresdeSalud(AppContext appContext)
        {
            _appContext = appContext;
        }
        IndicadoresdeSalud IRepositorioIndicadoresdeSalud.AddIndicadoresdeSalud(IndicadoresdeSalud indicadoresdeSalud)
        {
            var IndicadoresdeSaludAdicionados = _appContext.IndicadoresSdeSalud.add(indicadoresdeSalud);
            _appContext.SaveChanges();
            return IndicadoresdeSaludAdicionado.Entity;
        }
        void IRepositorioIndicadoresdeSalud.DeleteIndicadoresdeSalud(int IdIndicadoresdeSalud)
        {
            var indicadoresdeSaludEncontrado = _appContext.IndicadoresSdeSalud.FirstOrDefault(c => c.Id == IdIndicadoresdeSalud);
            if (indicadoresdeSaludEncontrado == null)
                return;
            _appContext.IndicadoresSdeSalud.Remove(indicadoresdeSaludEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<IndicadoresdeSalud> IRepositorioIndicadoresdeSalud.GetAllIndicadoresSdeSalud()
        {
            return _appContext.IndicadoresSdeSalud;
        }

        IndicadoresdeSalud IRepositorioIndicadoresdeSalud.GetIndicadoresdeSalud(int IdIndicadoresdeSalud)
        {
            return _appContext.IndicadoresSdeSalud.FirstOrDefault(indicadoresdeSaludEncontrado => c.Id == IdIndicadoresdeSalud);
        }

        IndicadoresdeSalud IRepositorioIndicadoresdeSalud.UpdateIndicadoresdeSalud(IndicadoresdeSalud indicadoresdeSalud)
        {
            var indicadoresdeSaludEncontrado = _appContext.IndicadoresSdeSalud.FirstOrDefault(indicadoresdeSaludEncontrado => c.Id == indicadoresdeSalud.Id);
            if (indicadoresdeSaludEncontrado != null)
            {
                indicadoresdeSaludEncontrado.Id = indicadoresdeSalud.Id;
                indicadoresdeSalud.IdCaballo = indicadoresdeSalud.IdCaballo;
                indicadoresdeSalud.IdVeterinario= indicadoresdeSalud.IdVeterinario;
                indicadoresdeSalud.IdPropietario = indicadoresdeSaludo.IdPropietario;
                indicadoresdeSalud.Temperatura = indicadoresdeSalud.Temperatura;
                indicadoresdeSalud.Peso = indicadoresdeSalud.Peso;
                indicadoresdeSalud.Frecuencia_Respiratoria = indicadoresdeSalud.Frecuencia_Respiratoria;
                indicadoresdeSalud.Frecuencia_Cardiaca = indicadoresdeSalud.Frecuencia_Cardiaca;
                indicadoresdeSalud.EstadodeAnimo =indicadoresdeSalud.EstadodeAnimo;
                indicadoresdeSalud.FechaVisita = indicadoresdeSalud.FechaVisita;
                indicadoresdeSalud.Recomendaciones = indicadoresdeSalud.Recomendaciones;
                indicadoresdeSalud.Medicamentos = indicadoresdeSalud.Medicamentos;



                _appContext.SaveChanges();

            }
            return IndicadoresdeSaludEncontrado;
        }
    }
}
