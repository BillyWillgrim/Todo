using Blazored.LocalStorage;
using System.Collections.Generic;
using System.Threading.Tasks;
using Todo.Models;
using Todo.Services.Interfaces;

namespace Todo.Services
{
    public class ToDoListService : IToDoListService
    {
        const string storageKey = "todoList";
        private readonly ILocalStorageService _localStorageService;

        public ToDoListService(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        public async Task Save(IEnumerable<TodoItem> todoList)
        {
            await _localStorageService.SetItemAsync(storageKey, todoList);
        }

        public async Task<IEnumerable<TodoItem>> Get()
        {
            return await _localStorageService.GetItemAsync<IEnumerable<TodoItem>>(storageKey);

        }

    }
}
