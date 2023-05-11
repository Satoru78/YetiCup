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
using YetiCup.Context;
using YetiCup.Model;
using YetiCup.Views.Windows;

namespace YetiCup
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Championships Championships { get; set; }
        public Authorization()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txbChampName.Text == "" && txbID.Text == "" && txbPass.Text== "")
                {
                    throw new Exception("Заполните все поля!");
                }
                else
                {
                    var currentUser = Data.db.Organizer.FirstOrDefault(item => item.password == txbPass.Text && item.Championships.championship_name == txbChampName.Text && item.id.ToString() == txbID.Text);
                    if (currentUser != null)
                    {
                        WinMain winMain = new WinMain();
                        winMain.ShowDialog();
                    }
                    else
                    {
                        throw new Exception("Ввведены неверные данные");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
