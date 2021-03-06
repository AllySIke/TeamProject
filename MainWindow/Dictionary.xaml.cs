﻿using System;
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
using TeamProject;
using TeamProject.UserData;

namespace MainWindow
{
    /// <summary>
    /// Логика взаимодействия для Dictionary.xaml
    /// </summary>
    public partial class Dictionary : Window
    {
        User user;
        public Dictionary(User _user)
        {
            InitializeComponent();
            user = _user;
            List<Hieroglyph> hieroglyphs = new List<Hieroglyph>();
            try
            {
                using (var context = new Context())
                {
                    foreach (var favo in (from h in context.Favourites.Where(u => u.UserMail == user.Email
                                   && (u.TaskOneRight == false || u.TaskTwoRight == false
                                   || u.TaskThreeRight == false))
                                          select h).ToList())
                    {
                        hieroglyphs.Add(context.Hieroglyphs.FirstOrDefault(h => h.ChineseWord == favo.Hieroglyph));
                    }

                }
            }
            catch (Exception)
            { 
                MessageBox.Show("Please check", "Something's wrong with the DataBase!");
                throw;
            }
            
            UnknownWords.ItemsSource = null;
            UnknownWords.ItemsSource = hieroglyphs;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            var taskChoosing = new TaskChoosing(user);
            taskChoosing.Show();
            this.Close();
        }
    }
}
