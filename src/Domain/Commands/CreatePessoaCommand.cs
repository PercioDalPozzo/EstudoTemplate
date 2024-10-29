using MediatR;

namespace Domain.Commands;

public class CreatePessoaCommand : IRequest<CreatePessoaCommandResponse>
{
    public string Nome { get; set; } = String.Empty;
    public DateTime Nascimento { get; set; }
}