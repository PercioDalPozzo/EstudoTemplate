using Domain.Interfaces;
using MediatR;

namespace Domain.Queries;

public class GetPessoaQueryHandler : IRequestHandler<GetPessoaQuery, GetPessoaQueryResponse>
{
    private readonly IPessoaRepository _pessoaRepository;
    
    public GetPessoaQueryHandler(IPessoaRepository pessoaRepository)
    {
        _pessoaRepository = pessoaRepository;
    }
    
    public async Task<GetPessoaQueryResponse> Handle(GetPessoaQuery query, CancellationToken cancellationToken)
    {
        var record = await _pessoaRepository.GetAll(query.Id);
        return new GetPessoaQueryResponse(query.OrigemConsulta,record);
    }
}