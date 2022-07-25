using Add.Application.Interfaces.Repository;
using App.Persistence.Context;
using App.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace App.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceService(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memoryDb"));
        serviceCollection.AddTransient<IEntity1Repository, Entity1Repository>();
    }
}