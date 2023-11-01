using CalculadoraCDB.Dominio.Entidades;

namespace CalculadoraCDB.Aplicacao.Interfaces
{
    public interface ICalculadoraCdbAppService
	{
		ResultadoCdb Calcular(decimal valor, int meses);
	}
}
