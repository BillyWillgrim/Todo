using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Models;
using Todo.Services.Interfaces;

namespace Todo.Pages
{
    public partial class ToDoListComponent
    {
        [Inject]
        public IToDoListService toDoListService { get; set; }

        public IList<TodoItem> TodoItems { get; set; }

        public string NewTodoItemName { get; set; } = string.Empty;

        public bool IsInputEmpty => NewTodoItemName == string.Empty;

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(1000);
            TodoItems = (await toDoListService.Get()).ToList();
        }

        public void AddTodoItemToList()
        {
            TodoItems.Add(new TodoItem() { Name = NewTodoItemName });
            NewTodoItemName = string.Empty;
            toDoListService.Save(TodoItems);
        }

        public void RemoveTodoItem(TodoItem item)
        {
            TodoItems.Remove(item);
            toDoListService.Save(TodoItems);
        }
    }
}
