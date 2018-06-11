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
    /// Логика взаимодействия для Task.xaml
    /// </summary>
    public partial class Task : Window
    {
        int howManyRightAnsweres = 0;
        int amountOfQuestionsPassed = 0;
        User user;
        public Task(int task, User _user)
        {
            InitializeComponent();
            user = _user;
            if (task == 1)
            {

            }
            if (task == 2)
            {

            }
            if (task == 3)
            {

            }
        }

        private void VarOne_Click(object sender, RoutedEventArgs e)
        {
            amountOfQuestionsPassed += 1;
            //Question.Text = 
            //VarOne.Content = 
            //ыыы как сделать рандом надо погуглить
        }

        private void VarTwo_Click(object sender, RoutedEventArgs e)
        {
            amountOfQuestionsPassed += 1;
        }

        private void VarThree_Click(object sender, RoutedEventArgs e)
        {
            amountOfQuestionsPassed += 1;
        }

        private void VarFour_Click(object sender, RoutedEventArgs e)
        {
            amountOfQuestionsPassed += 1;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            //спросить у юзера уверен ли он выйти/закончить
            (new TaskChoosing(user)).Show();
            this.Close();
        }
    }
}
