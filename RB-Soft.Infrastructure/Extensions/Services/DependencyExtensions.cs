using Microsoft.Extensions.DependencyInjection;

using RB_Soft.Data.Core;

namespace RB_Soft.Infrastructure.Extensions.Services
{
    internal static class DependencyExtensions
	{
		public static IServiceCollection AddRepositories(this IServiceCollection services)
		{
			//services.AddScoped<ApplicationDbContext>();

			services.AddScoped<IDatabaseTransaction, DatabaseTransaction>();
			services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

			//services.AddScoped<IContactRepository, ContactRepository>();
			//services.AddScoped<IAccountRepository, AccountRepository>();
			//services.AddScoped<IIncidentRepository, IncidentRepository>();

			return services;
		}
	}
}
