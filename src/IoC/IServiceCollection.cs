using System.Reflection;
using Domain.Interfaces;
using Domain.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository;

namespace IoC;

public static class IoC
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IPessoaRepository, PessoaRepository>();
        services.AddScoped<IProvisionamentoService, ProvisionamentoService>();
        
        services.AddMediatR(Assembly.Load("Domain"));         

        services.AddDbContext<ApplicationContext>(options => options.UseInMemoryDatabase("InMemoryDb"), ServiceLifetime.Singleton);        
    }
}