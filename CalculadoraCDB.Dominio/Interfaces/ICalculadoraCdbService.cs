using CalculadoraCDB.Dominio.Entidades;

namespace CalculadoraCDB.Dominio.Interfaces
{
    public interface ICalculadoraCdbService
	{
		ResultadoCdb Calcular(Cdb cdb);
	}
}
