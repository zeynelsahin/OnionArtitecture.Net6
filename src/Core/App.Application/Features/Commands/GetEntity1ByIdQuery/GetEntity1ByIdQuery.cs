using Add.Application.Dto;
using Add.Application.Wrappers;
using MediatR;

namespace Add.Application.Features.Commands.GetEntity1ByIdQuery;

public class GetEntity1ByIdQuery: IRequest<ServiceResponse<GetEntity1ByViewModel>>
{
    public Guid Id { get; set; }
}