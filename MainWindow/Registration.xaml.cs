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

        private bool EMailCheck(string mailOrNot)
        {
            var a = mailOrNot.ToCharArray();
            var word = new List<char>();
            int amountOf = 0;
            int amountOfDots = 0;
            foreach (var letter in a)
            {
                word.Add(letter);

                if (letter.Equals('@'))
                    amountOf += 1;

                if (letter.Equals('.'))
                    amountOfDots += 1;
            }

            if (amountOfDots == 1 && amountOf == 1 && a.ElementAt(0) != '@' && a.ElementAt(0) != '.'
                && a.ElementAt(a.Count() - 1) != '@' && a.ElementAt(a.Count() - 1) != '.'
                && word.IndexOf('@') <= word.IndexOf('.') + 1)
                return true;
            else
            {
                return false;
            }
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text != "")
            {
                if (email.Text != "")
                {
                    if (EMailCheck(email.Text))
                    {
                        if (password.Password != "")
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
                                        context.Favourites.AddOrUpdate (new Favourite
                                        {
                                            Hieroglyph = hierogl.ChineseWord,
                                            TaskOneRight = false,
                                            TaskTwoRight = false,
                                            TaskThreeRight = false,
                                            UserMail = user.Email
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
                        MessageBox.Show("Invalid Email");
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
