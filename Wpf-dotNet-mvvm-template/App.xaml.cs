using System.Windows;

namespace Wpf_dotNet_mvvm_template
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow = new Views.MainWindowView();
            MainWindow.Show();
        }
    }
}