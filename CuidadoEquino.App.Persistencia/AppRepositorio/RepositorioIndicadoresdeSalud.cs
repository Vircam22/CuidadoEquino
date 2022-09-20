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
        
        public IndicadoresdeSalud AddIndicadoresdeSalud(IndicadoresdeSalud indicadoresdeSalud)
        {
            var IndicadoresdeSaludAdicionado = _appContext.IndicadoresdeSalud.Add(indicadoresdeSalud);
            _appContext.SaveChanges();
            return IndicadoresdeSaludAdicionado.Entity;
        }
        
        public void DeleteIndicadoresdeSalud(int IdIndicadoresdeSalud)
        {
            var IndicadoresdeSaludEncontrado = _appContext.IndicadoresdeSalud.FirstOrDefault(c => c.Id == IdIndicadoresdeSalud);
            if (IndicadoresdeSaludEncontrado == null)
                return;
            _appContext.IndicadoresdeSalud.Remove(IndicadoresdeSaludEncontrado);
            _appContext.SaveChanges();

        }

        public IEnumerable<IndicadoresdeSalud> GetAllIndicadoresdeSalud()
        {
            return _appContext.IndicadoresdeSalud;
        }

        public IndicadoresdeSalud GetIndicadoresdeSalud(int IdIndicadoresdeSalud)
        {
            return _appContext.IndicadoresdeSalud.FirstOrDefault(indicadoresdeSaludEncontrado => indicadoresdeSaludEncontrado.Id == IdIndicadoresdeSalud);
        }

        public IndicadoresdeSalud UpdateIndicadoresdeSalud(IndicadoresdeSalud indicadoresdeSalud)
        {
            var indicadoresdeSaludEncontrado = _appContext.IndicadoresdeSalud.FirstOrDefault(indicadoresdeSaludEncontrado => indicadoresdeSaludEncontrado.Id == indicadoresdeSalud.Id);
            if (indicadoresdeSaludEncontrado != null)
            {
                indicadoresdeSaludEncontrado.Id = indicadoresdeSalud.Id;
                indicadoresdeSaludEncontrado.Id_Caballo_Veterinario = indicadoresdeSalud.Id_Caballo_Veterinario;
                indicadoresdeSaludEncontrado.Temperatura = indicadoresdeSalud.Temperatura;
                indicadoresdeSaludEncontrado.Peso = indicadoresdeSalud.Peso;
                indicadoresdeSaludEncontrado.Frecuencia_Respiratoria = indicadoresdeSalud.Frecuencia_Respiratoria;
                indicadoresdeSaludEncontrado.Frecuencia_Cardiaca = indicadoresdeSalud.Frecuencia_Cardiaca;
                indicadoresdeSaludEncontrado.EstadodeAnimo =indicadoresdeSalud.EstadodeAnimo;
                indicadoresdeSaludEncontrado.FechaVisita = indicadoresdeSalud.FechaVisita;
                indicadoresdeSaludEncontrado.Recomendaciones = indicadoresdeSalud.Recomendaciones;
                indicadoresdeSaludEncontrado.Medicamentos = indicadoresdeSalud.Medicamentos;

                _appContext.SaveChanges();

            }
            return indicadoresdeSaludEncontrado;
        }
    }
}
