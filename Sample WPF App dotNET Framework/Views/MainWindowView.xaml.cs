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
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
        }
    }
    public static class Log
    {
        public enum LogType
        {
            Standard,
            Warning,
            Error
        }
        public static event Action<object, Log.LogType> LogHandler;
        private static void Logger(object e, bool crash, Log.LogType type)
        {
            LogHandler(e, type);
            if (crash)
                throw new Exception(e.ToString());
        }
        #region public functions
        public static void Standard(object e, bool crash = false) => Logger(e, crash, Log.LogType.Standard);
        public static void Warning(object e, bool crash = false) => Logger(e, crash, Log.LogType.Warning);
        public static void Error(object e, bool crash = false) => Logger(e, crash, Log.LogType.Error);
        #endregion
    }
}
