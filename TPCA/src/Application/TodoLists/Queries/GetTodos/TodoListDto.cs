using TPCA.Application.Common.Mappings;
using TPCA.Domain.Entities;

namespace TPCA.Application.TodoLists.Queries.GetTodos;

public class TodoListDto : IMapFrom<TodoList>
{
    public TodoListDto()
    {
        Items = new List<TodoItemDto>();
    }

    public int Id { get; set; }

    public string? Title { get; set; }
    public string? Name { get; set; }
    public int MaxCount { get; set; }
    public string? Colour { get; set; }

    public IList<TodoItemDto> Items { get; set; }
}
