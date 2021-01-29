using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Models;

namespace Todo.Pages
{
    public partial class ToDoListComponent
    {

        public IList<TodoItem> TodoItems { get; } = new List<TodoItem> { new TodoItem { Name = "Add Css" }, new TodoItem { Name = "Add API" }, new TodoItem { Name = "Get some grub" } };

        public string NewTodoItemName { get; set; } = string.Empty;

        public bool IsInputEmpty => NewTodoItemName == string.Empty;

        public void AddTodoItemToList()
        {
            TodoItems.Add(new TodoItem() { Name = NewTodoItemName });
            NewTodoItemName = string.Empty;
        }
    }
}
