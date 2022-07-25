using System.Reflection;
using Add.Application.Mapping.AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Add.Application;

public static class ServiceRegistration
{
    public static void AddApplicationRegistration(this IServiceCollection service)
    {
        var assembly = Assembly.GetExecutingAssembly();
        service.AddAutoMapper(opt => opt.AddProfile(new GeneralMapping()));
        service.AddMediatR(assembly);
    }
}