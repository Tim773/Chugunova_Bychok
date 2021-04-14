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
using Chugunova_Bychok.Windows;
using static Chugunova_Bychok.Windows.AppData;


namespace Chugunova_Bychok
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Autoriz : Window
    {
        
      
        public Autoriz()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            
               var user = context.Users.ToList().
                Where(i => i.logim == login.Text && i.password == password.Password).
                FirstOrDefault();


            if (user != null)
            {
                usersData = user;

                UserWin userWin = new UserWin();
                this.Hide();
                userWin.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Ползователь не найден!!!");
            }

        }

        private void Registr_Click(object sender, RoutedEventArgs e)
        {
            Registr registr = new Registr();
            Close();
            registr.ShowDialog();
           
        }
    }
}
