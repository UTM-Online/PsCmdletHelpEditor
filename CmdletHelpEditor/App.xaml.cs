﻿using System;
using System.Windows;
using CmdletHelpEditor.API.ViewModels;
using CmdletHelpEditor.Views.Windows;

namespace CmdletHelpEditor {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App {
        void ApplicationStartup(Object sender, StartupEventArgs e) {
            ((App)sender).MainWindow = new MainWindow();
            if (e.Args.Length == 1) {
                ((MainWindowVM)((App)sender).MainWindow.DataContext).CommandManager.OpenProject(e.Args[0]);
            }
            ((App)sender).MainWindow.Show();
        }
    }
}
