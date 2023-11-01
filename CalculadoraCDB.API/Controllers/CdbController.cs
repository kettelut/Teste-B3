using CalculadoraCDB.Aplicacao.Interfaces;
using CalculadoraCDB.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraCDB.API.Controllers
{
    [ApiController]
	[Route("api/[controller]")]
	public class CdbController : ControllerBase
	{
		private readonly ICalculadoraCdbService _calculadoraCdbService;

		private readonly ILogger<CdbController> _logger;

		public CdbController(ILogger<CdbController> logger, ICalculadoraCdbService calculadoraCdbService)
		{
			_logger = logger;
			_calculadoraCdbService = calculadoraCdbService;
		}

		[HttpPost("Calcular")]
		public IActionResult GetCalculo([FromBody] Cdb input)
		{
			_logger.LogInformation($@"Calcular o CDB do Valor {input.Valor} para {input.Meses} Meses.");
			var result = _calculadoraCdbService.Calcular(input);
			return Ok(result);
		}
	}
}