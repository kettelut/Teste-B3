using CalculadoraCDB.Aplicacao.Interfaces;
using CalculadoraCDB.Aplicacao.Servicos;
using CalculadoraCDB.Dominio.Interfaces;
using CalculadoraCDB.Dominio.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CalculadoraCDB.Infra.IoC
{
	public static class DependencyInjection
	{
		public static void AddApplicationDependencies(this IServiceCollection serviceCollection, IConfiguration configuration)
		{
			AddApplicationDependencies(serviceCollection);
		}

		public static void AddApplicationDependencies(this IServiceCollection serviceCollection)
		{
			// Aplicação
			serviceCollection.AddScoped<ICalculadoraCdbAppService, CalculadoraCdbAppService>();

			// Domínio
			serviceCollection.AddScoped<ICalculadoraCdbService, CalculadoraCdbService>();
		}
	}
}
