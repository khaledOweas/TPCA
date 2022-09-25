using TPCA.Application.TodoLists.Queries.ExportTodos;

namespace TPCA.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
