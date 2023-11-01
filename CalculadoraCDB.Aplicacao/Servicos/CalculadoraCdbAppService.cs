using CalculadoraCDB.Aplicacao.Interfaces;
using CalculadoraCDB.Dominio.Entidades;
using CalculadoraCDB.Dominio.Interfaces;

namespace CalculadoraCDB.Aplicacao.Servicos
{
	public class CalculadoraCdbAppService : ICalculadoraCdbAppService
	{
		private readonly ICalculadoraCdbService _calculadoraCdbService;

		public CalculadoraCdbAppService(ICalculadoraCdbService calculadoraCdbService)
		{
			_calculadoraCdbService = calculadoraCdbService;
		}

		public ResultadoCdb Calcular(decimal valor, int meses)
		{
			Cdb cdb = new Cdb { 
				Valor = valor, 
				Meses = meses 
			};

			return _calculadoraCdbService.Calcular(cdb);
		}
	}
}
