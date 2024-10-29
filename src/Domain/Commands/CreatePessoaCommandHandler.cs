using Domain.Entities;
using Domain.Interfaces;
using MediatR;

namespace Domain.Commands;

public class CreatePessoaCommandHandler : IRequestHandler<CreatePessoaCommand, CreatePessoaCommandResponse>
{
    private readonly IPessoaRepository _pessoaRepository;
    
    public CreatePessoaCommandHandler(IPessoaRepository pessoaRepository)
    {
        _pessoaRepository = pessoaRepository;
    }

    public async Task<CreatePessoaCommandResponse> Handle(CreatePessoaCommand command, CancellationToken cancellationToken)
    {
        var novo = new Pessoa()
        {
            Nome = command.Nome,
            Nascimento = command.Nascimento
        };
        
        await _pessoaRepository.AddAsync(novo);

        return new CreatePessoaCommandResponse(novo.Id);
    }
}