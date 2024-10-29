using MediatR;

namespace Domain.Queries;

public record GetPessoaQuery(string OrigemConsulta, Guid? Id) : IRequest<GetPessoaQueryResponse>
{
}