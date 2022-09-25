using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TPCA.Application.Common.Exceptions;
using TPCA.Application.Common.Interfaces;
using TPCA.Domain.Entities;

namespace TPCA.Application.Zobas.Commands.UpdateZoba;
public class UpdateZobaCommand : IRequest
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Description { get; set; }
}

public class UpdateZobaCommandHandler : IRequestHandler<UpdateZobaCommand>
{
    private readonly IApplicationDbContext _context;

    public UpdateZobaCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(UpdateZobaCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Zobas.FindAsync(new object[] { request.Id }, cancellationToken);


        if (entity == null)
        {
            throw new NotFoundException(nameof(Zoba), request.Id);
        }


        entity.Name = request.Name;
        entity.Description = request.Description;
        entity.Age = request.Age;

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}