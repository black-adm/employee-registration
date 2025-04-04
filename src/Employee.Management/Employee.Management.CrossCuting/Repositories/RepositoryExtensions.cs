using Employee.Management.Data.Repositories;
using Employee.Management.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Employee.Management.CrossCuting.Repositories;

public static class RepositoryExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ICompanyRepository, CompanyRepository>();
        return services;
    }
}