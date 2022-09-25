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

namespace TPCA.Application.Zobas.Commands.DeleteZoba;

public record DeleteZobaCommand(int Id) : IRequest;
public class DeleteZobaCommandHandler : IRequestHandler<DeleteZobaCommand>
{
    private readonly IApplicationDbContext _context;

    public DeleteZobaCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeleteZobaCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Zobas.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
        if (entity == null)
        {
            throw new NotFoundException(nameof(TodoList), request.Id);
        }
        _context.Zobas.Remove(entity);
        await _context.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}
