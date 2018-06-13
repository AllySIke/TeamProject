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
    /// Логика взаимодействия для TaskChoosing.xaml
    /// </summary>
    public partial class TaskChoosing : Window
    {
        User user;

        public TaskChoosing(User _user)
        {
            InitializeComponent();
            user = _user;
        }

        private void Piniyn_Click(object sender, RoutedEventArgs e)
        {
            var task = new Tasks(1, user);
            task.Show();
            this.Close();
        }

        private void Hieroglyph_Click(object sender, RoutedEventArgs e)
        {
            var task = new Tasks(2, user);
            task.Show();
            this.Close();
        }

        private void Translation_Click(object sender, RoutedEventArgs e)
        {
            var task = new Tasks(3, user);
            task.Show();
            this.Close();
        }

        private void Dictionary_Click(object sender, RoutedEventArgs e)
        {
            var dict = new Dictionary(user);
            dict.Show();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            var logIn = new LogIn();
            logIn.Show();
            this.Close();
        }
    }
}
