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
using System.Windows.Shapes;
using YetiCup.Views.Pages;

namespace YetiCup.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для WinMain.xaml
    /// </summary>
    public partial class WinMain : Window
    {
        public WinMain()
        {
            InitializeComponent();
            MainFrame.Navigate(new MainListPage());
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
