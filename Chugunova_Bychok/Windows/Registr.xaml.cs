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
using Chugunova_Bychok.Windows;
using static Chugunova_Bychok.Windows.AppData;


namespace Chugunova_Bychok
{
    /// <summary>
    /// Логика взаимодействия для Registr.xaml
    /// </summary>
    public partial class Registr : Window
    {
        

        public Registr()
        {
            InitializeComponent();
        }

        private void Pol_Loaded(object sender, RoutedEventArgs e)
        {
            var gen = context.Gender;
            pol.ItemsSource = gen.ToList();
        }
  
        private void Okreg_Click(object sender, RoutedEventArgs e)
        {
            if (lname.Text == null || 
                fname.Text == null ||
                login.Text == null ||
                pass.Text == null ||
                pol.SelectedItem == null ||
                old.Text == null || 
                wes.Text == null ||
                rost == null )
            {
                MessageBox.Show("Вы указали не все данные");
            }
            else
            {
                Users users = context.Users.Add(new Users
                {
                    l_Name = lname.Text,
                    f_Name = fname.Text,
                    logim = login.Text,
                    password = pass.Text,
                    ID_Gender = pol.SelectedIndex + 1,
                    dob = old.SelectedDate ?? DateTime.MinValue,
                    weight = Convert.ToInt32(wes.Text),
                    height = Convert.ToInt32(rost.Text)
                }) ;

            }
        }

        private void Exit1_Click(object sender, RoutedEventArgs e)
        {
            Autoriz autoriz = new Autoriz();
            this.Close();
            autoriz.ShowDialog();
        }

       
    }
}
