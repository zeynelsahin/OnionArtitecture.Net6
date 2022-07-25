using Add.Application.Dto;
using Add.Application.Interfaces.Repository;
using Add.Application.Wrappers;
using AutoMapper;
using MediatR;

namespace Add.Application.Features.Commands.GetEntity1ByIdQuery;

public class GetEntity1ByIdQueryHandler: IRequestHandler<GetEntity1ByIdQuery,ServiceResponse<GetEntity1ByViewModel>>
{
    private readonly IEntity1Repository _entity1Repository;
    private readonly IMapper _mapper;
    

    public GetEntity1ByIdQueryHandler(IEntity1Repository entity1Repository, IMapper mapper)
    {
        _entity1Repository = entity1Repository;
        _mapper = mapper;
    }

    public async Task<ServiceResponse<GetEntity1ByViewModel>> Handle(GetEntity1ByIdQuery request, CancellationToken cancellationToken)
    {
        var entity1 = await _entity1Repository.GetByIdAsync(request.Id);
        var dto = _mapper.Map<GetEntity1ByViewModel>(entity1);
        return new ServiceResponse<GetEntity1ByViewModel>(dto);
    }
}