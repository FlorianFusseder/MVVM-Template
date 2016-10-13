using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_Vorlage
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        

        protected override void OnStartup(StartupEventArgs e)
        {
            

            MainWindow = new MainWindow
            {
                Title = "MVVM",
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                Height = 250,
                Width = 250
            };

            MainWindow.Show();
        }
    }
}
