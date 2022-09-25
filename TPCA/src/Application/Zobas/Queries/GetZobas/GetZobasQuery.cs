using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TPCA.Application.Common.Interfaces;
using TPCA.Application.Common.Security;
namespace TPCA.Application.Zobas.Queries.GetZobas;

[Authorize]
public record GetZobaQuery : IRequest<ZobasVM>;
public class GetZobasQueryHandler : IRequestHandler<GetZobaQuery, ZobasVM>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetZobasQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<ZobasVM> Handle(GetZobaQuery request, CancellationToken cancellationToken)
    {
        return new ZobasVM()
        {
            Zobas = await _context.Zobas.AsNoTracking().ProjectTo<ZobaDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
        };
    }
}


