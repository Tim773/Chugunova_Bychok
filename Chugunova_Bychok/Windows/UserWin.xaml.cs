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
using static Chugunova_Bychok.Windows.AppData;

namespace Chugunova_Bychok.Windows
{
    /// <summary>
    /// Логика взаимодействия для UserWin.xaml
    /// </summary>
    public partial class UserWin : Window
    {
        public UserWin()
        {
            InitializeComponent();
            txtb_fName.Text = usersData.f_Name;
            txtb_lName.Text = usersData.l_Name;
            txtb_weight.Text = Convert.ToString(usersData.weight);
            txtb_height.Text = Convert.ToString(usersData.height);
            txtb_old.Text = Convert.ToString(usersData.age);
            txtb_imt.Text = Raschet.Calculation.GetBMI(usersData.weight, usersData.height);
            txtb_bmr.Text = Raschet.Calculation.GetBMR(usersData.weight, usersData.height, usersData.ID_Gender, Convert.ToInt32(usersData.age)).ToString();
        }

        private void Changephoto_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Exit1_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
            
        }
    }
}
