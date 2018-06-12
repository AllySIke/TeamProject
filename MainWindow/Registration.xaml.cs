using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
using TeamProject;
using TeamProject.UserData;

namespace MainWindow
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text != null)
            {
                if (email.Text != null)
                {
                    if (true)//проверка на имейл!!!!!!1!!!!1!11!!
                    {
                        if (password.Password != null)
                        {
                            using (var context = new Context())
                            {
                                var encrypt = new Encryption();
                                if (!context.Users.Any(u => u.Email == email.Text))
                                {
                                    User user = new User
                                    {
                                        FullName = name.Text,
                                        Email = email.Text,
                                        Password = encrypt.GetHash(password.Password)
                                    };
                                    context.Users.AddOrUpdate(user);
                                    
                                    foreach(var hierogl in context.Hieroglyphs)
                                    {
                                        context.Favourites.AddOrUpdate(new Favourite
                                        {
                                            Hieroglyph = hierogl,
                                            TaskOneRight = false,
                                            TaskTwoRight = false,
                                            TaskThreeRight = false,
                                            UserMail = user
                                        });
                                    };
                                    context.SaveChanges();

                                    var logIn = new LogIn();
                                    logIn.Show();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("This email is already registered, please choose another");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter your password!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Emmail");
                    }
                }
                else
                {
                    MessageBox.Show("Enter your Email!");
                }
            }
            else
            {
                MessageBox.Show("Enter your name!");
            }
        }
    }
}
