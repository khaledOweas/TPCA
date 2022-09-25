using TPCA.Application.Common.Mappings;
using TPCA.Domain.Entities;

namespace TPCA.Application.Common.Models;

// Note: This is currently just used to demonstrate applying multiple IMapFrom attributes.
public class LookupDto : IMapFrom<TodoList>, IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public string? Title { get; set; } 
    public string? Name { get; set; }
    public int MaxCount { get; set; }
}
