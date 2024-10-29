using Domain.Entities;

namespace Domain.Queries;

public record GetPessoaQueryResponse(string OrigemConsulta, IReadOnlyList<Pessoa> Records ){ }