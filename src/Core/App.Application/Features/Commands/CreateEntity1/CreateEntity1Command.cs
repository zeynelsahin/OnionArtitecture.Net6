using Add.Application.Interfaces.Repository;
using Add.Application.Wrappers;
using AutoMapper;
using MediatR;

namespace Add.Application.Features.Commands.CreateEntity1;

public class CreateEntity1Command : IRequest<ServiceResponse<Guid>>
{
    public string Name { get; set; }
    public decimal Value { get; set; }
    public int Quantity { get; set; }

    public class CreateProductCommandHandler : IRequestHandler<CreateEntity1Command, ServiceResponse<Guid>>
    {
        private readonly IEntity1Repository _entity1Repository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IEntity1Repository entity1Repository, IMapper mapper)
        {
            _entity1Repository = entity1Repository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<Guid>> Handle(CreateEntity1Command request, CancellationToken cancellationToken)
        {
            var entity1 = _mapper.Map<App.Domain.Entities.Entity1>(request);
            await _entity1Repository.AddAsync(entity1);
            return new ServiceResponse<Guid>(entity1.Id);
        }
    }
}