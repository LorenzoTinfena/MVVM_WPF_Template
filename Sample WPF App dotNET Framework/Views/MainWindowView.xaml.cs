using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sample_WPF_App_dotNET_Framework.Views
{
    internal partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
        }
    }

    internal static class Log
    {
        public static void Standard(object e, bool crash = false)
        {
            throw new NotImplementedException();
        }
        public static void Warning(object e, bool crash = false)
        {
            throw new NotImplementedException();
        }
        public static void Error(object e, bool crash = false)
        {
            throw new NotImplementedException();
        }
    }
}
