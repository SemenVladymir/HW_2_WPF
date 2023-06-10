using System;
using System.Windows;


namespace HW_2_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Application.Current.Resources = Application.LoadComponent(new Uri("StyleResource.xaml", UriKind.Relative)) as ResourceDictionary;
            InitializeComponent();
        }
    }
}
