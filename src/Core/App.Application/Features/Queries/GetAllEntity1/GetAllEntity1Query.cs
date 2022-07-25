using Add.Application.Dto;
using Add.Application.Interfaces.Repository;
using Add.Application.Wrappers;
using AutoMapper;
using MediatR;

namespace Add.Application.Features.Queries.GetAllEntity1;

public class GetAllEntity1Query : IRequest<ServiceResponse<List<Entity1ViewDto>>>
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllEntity1Query, ServiceResponse<List<Entity1ViewDto>>>
    {
        private readonly IEntity1Repository _repository;
        private readonly IMapper _mapper;

        public GetAllProductsQueryHandler(IEntity1Repository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<Entity1ViewDto>>> Handle(GetAllEntity1Query request, CancellationToken cancellationToken)
        {
            var products = await _repository.GetAllAsync();
            var viewModel = _mapper.Map<List<Entity1ViewDto>>(products);
            return new ServiceResponse<List<Entity1ViewDto>>(viewModel);  
        }
    }
}