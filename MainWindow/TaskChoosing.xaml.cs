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

        }

        private void Hieroglyph_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Translation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Dictionary_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
