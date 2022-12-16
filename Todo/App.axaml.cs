using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Todo.ViewModels;
using Todo.Views;

namespace Todo
{
    public partial class App : Application
    {
        public static MainWindow MainView;
        
        
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
                MainView = (MainWindow) desktop.MainWindow;
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}