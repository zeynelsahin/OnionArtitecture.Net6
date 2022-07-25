using Add.Application.Features.Commands.CreateEntity1;
using Add.Application.Features.Commands.GetEntity1ByIdQuery;
using Add.Application.Features.Queries.GetAllEntity1;
using Add.Application.Interfaces.Repository;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("")]
public class Entity1Controller : Controller
{
    private readonly IMediator _mediator;

    public Entity1Controller(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var query = new GetAllEntity1Query();
        return Ok(await _mediator.Send(query));
    }
    [HttpPost]
    public async Task<IActionResult> AddEntity1(CreateEntity1Command createEntity1Command)
    {
        return Ok(await _mediator.Send(createEntity1Command));
    }
    [HttpGet("/getById/{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var query = new GetEntity1ByIdQuery {Id = id,};
        var response = await _mediator.Send(query);
        return Ok(response);
    }

}