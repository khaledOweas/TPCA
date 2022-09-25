using TPCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace TPCA.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }
    DbSet<Zoba> Zobas { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
