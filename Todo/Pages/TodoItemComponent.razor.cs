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

        public void Delete()
        {
            Console.WriteLine($"Deleting {TodoItem.Name}");
        }
    }
}
