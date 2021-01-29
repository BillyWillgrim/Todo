using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Todo.Models;

namespace Todo.Pages
{
    public partial class TodoItemComponent
    {
        [Parameter] public TodoItem TodoItem { get; set; }

        [Parameter] public EventCallback<TodoItem> OnDelete { get; set; }

        public string NewName { get; set; }

        public bool Editing { get; set; }

        public void Edit()
        {
            NewName = TodoItem.Name;
            Editing = true;
        }
        public void Save()
        {
            TodoItem.Name = NewName;
            Editing = false;
        }

        public async Task Delete()
        {
            Console.WriteLine($"Deleting {TodoItem.Name}");
            await OnDelete.InvokeAsync(TodoItem);
        }
    }
}
