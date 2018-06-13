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
using TeamProject.UserData;

namespace MainWindow
{
    /// <summary>
    /// Логика взаимодействия для Congradulation.xaml
    /// </summary>
    public partial class Congratulation : Window
    {
        User user;
        public Congratulation(int result, User _user)
        {
            user = _user;
            InitializeComponent();
            Result.Text = $"Congratulations, {_user.FullName}! Your result is {result}/20. Would you like to open the dictionary?";
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            var chooseTask = new TaskChoosing(user);
            chooseTask.Show();
            this.Close();
        }

        private void Dictionary_Click(object sender, RoutedEventArgs e)
        {
            var dictionary = new Dictionary(user);
            dictionary.Show();
            this.Close();
        }
    }
}
