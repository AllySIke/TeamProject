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
using TeamProject;
using TeamProject.UserData;

namespace MainWindow
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            var register = new Registration();
            register.Show();
            this.Close();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (emailBox.Text!=null)
            {
                if(passwordBox.Password!=null)
                {
                    var encrypt = new Encryption();
                    var person = new User()
                    {
                        Email = emailBox.Text,
                        Password = encrypt.GetHash(passwordBox.Password)
                    };
                    using (var context = new Context())
                    {
                        var user = context.Users.FirstOrDefault(p => p.Email == person.Email && p.Password == person.Password);

                        if (user != null)
                        {
                            var taskChoosing = new TaskChoosing(user);
                            taskChoosing.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No such user!!!1");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter Password");
                }
            }
            else
            {
                MessageBox.Show("Enter email!");
            }
        }
    }
}
