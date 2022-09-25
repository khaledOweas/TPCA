using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TPCA.Application.Common.Interfaces;
using TPCA.Domain.Entities;

namespace TPCA.Application.Zobas.Commands.CreateZoba;
public class CreateZobaCommand : IRequest<int>
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Description { get; set; }
}


public class CreateZobaCommandHandler : IRequestHandler<CreateZobaCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateZobaCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateZobaCommand request, CancellationToken cancellationToken)
    {
        var entity = new Zoba
        {
            
            Name = request.Name,
            Age = request.Age,
            Description = request.Description
        };

        _context.Zobas.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}