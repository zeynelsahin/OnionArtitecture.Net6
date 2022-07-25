using Add.Application.Features.Commands.CreateEntity1;
using Add.Application.Features.Commands.GetEntity1ByIdQuery;
using AutoMapper;

namespace Add.Application.Mapping.AutoMapper;

public class GeneralMapping: Profile
{
    public GeneralMapping()
    {
        CreateMap<App.Domain.Entities.Entity1, Dto.Entity1ViewDto>().ReverseMap();
        CreateMap<App.Domain.Entities.Entity1, CreateEntity1Command>().ReverseMap();
        CreateMap<App.Domain.Entities.Entity1, GetEntity1ByViewModel>().ReverseMap();
        
    }
}