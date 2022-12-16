using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using DialogHost;
using Todo.ViewModels;

namespace Todo.UserControls;

public partial class TodoItemsUc : UserControl
{
    public TodoItemsUc()
    {
        InitializeComponent();
        DataContext = new TodoItemsUcVm();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void AddItemButton_OnClick(object? sender, RoutedEventArgs e)
    {
        DialogHost.DialogHost.Show(
            Resources["AddTodoItemDialog"], 
            "MainDialogHost",
            closingEventHandler: (o, args) =>
            {
                var description = args.Parameter?.ToString();
                if (string.IsNullOrWhiteSpace(description)) return;
                var vm = DataContext as TodoItemsUcVm;
                vm.AddItem(description);
            });
    }
}