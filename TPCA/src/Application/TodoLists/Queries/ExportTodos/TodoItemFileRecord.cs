using TPCA.Application.Common.Mappings;
using TPCA.Domain.Entities;

namespace TPCA.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
