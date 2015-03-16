// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="KUL.NET">
//   Created by Jarosław Wąsik
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Zad01
{
    using System.Windows;

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void PokazKomunikat(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Witaj świecie", "Pierwszy program");
        }
    }
}
