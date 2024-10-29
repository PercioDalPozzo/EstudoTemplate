using Domain.Commands;
using Domain.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EstudoTemplate.Controllers;

[ApiController]
[Route("/api/[controller]/")]
public class PessoaController : ControllerBase
{
    private readonly IMediator _mediator;

    public PessoaController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult> Get(string? id)
    {
        return Ok(await _mediator.Send(new GetPessoaQuery("Consulta controller", string.IsNullOrEmpty(id)? Guid.Empty : Guid.Parse(id))));
    }
    
    [HttpPost]
    public async Task<ActionResult> Post(CreatePessoaCommand dto)
    {
        var id = await _mediator.Send(dto);
        return Ok(id);
    }
}