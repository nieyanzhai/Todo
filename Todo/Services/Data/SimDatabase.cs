using System.Collections.Generic;
using Todo.Models;

namespace Todo.Services.Data;

public class SimDatabase
{
    public IEnumerable<TodoItem> GetTodoItems() =>
        new List<TodoItem>
        {
            new() {Description = "This is an item description 1."},
            new() {Description = "This is an item description 2."},
            new() {Description = "This is an item description 3.", IsChecked = true}
        };
}