using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Foodiet.Pages
{
    /// <summary>
    /// Interaction logic for Landing.xaml
    /// </summary>
    public partial class Landing : Page
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void Grid_click(object sender, RoutedEventArgs e)
        {
            NavButton ClickedButton = e.OriginalSource as NavButton;
            System.Diagnostics.Debug.WriteLine(e.OriginalSource.ToString());
            if (ClickedButton!=null)
            { 
            NavigationService.Navigate(ClickedButton.NavUri);
            }
        }

        private void button_signout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            var wnd = Window.GetWindow(this);
            //Window parentWindow = Application.Current.MainWindow;
            wnd.Close();
        }

    }
}
