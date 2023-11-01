using CalculadoraCDB.Dominio.Entidades;

namespace CalculadoraCDB.Aplicacao.Interfaces
{
    public interface ICalculadoraCdbService
	{
		ResultadoCdb Calcular(Cdb cdb);
	}
}
