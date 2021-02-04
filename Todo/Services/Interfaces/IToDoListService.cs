using System.Collections.Generic;
using System.Threading.Tasks;
using Todo.Models;

namespace Todo.Services.Interfaces
{
    public interface IToDoListService
    {
        Task<IEnumerable<TodoItem>> Get();
        Task Save(IEnumerable<TodoItem> todoList);
    }
}