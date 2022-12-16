using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using Todo.Models;
using Todo.Services.Data;

namespace Todo.ViewModels;

public partial class TodoItemsUcVm : ObservableObject
{
    [ObservableProperty] private IEnumerable<TodoItem> _todoItems;

    public TodoItemsUcVm()
    {
        var db = new SimDatabase();
        _todoItems = db.GetTodoItems();
    }
}