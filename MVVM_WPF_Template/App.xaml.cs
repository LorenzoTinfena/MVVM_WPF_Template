﻿using System.Windows;

namespace MVVM_WPF_Template
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