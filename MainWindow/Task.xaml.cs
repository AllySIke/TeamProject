using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Diagnostics;
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
    /// Логика взаимодействия для Task.xaml
    /// </summary>
    public partial class Tasks : Window
    {
        int howManyRightAnsweres = 0;
        int amountOfQuestionsPassed = 0;
        User user;
        Hieroglyph hieroglyph;
        List<Hieroglyph> hieroglyphs;
        int task;

        public Tasks(int _task, User _user)
        {
            InitializeComponent();
            user = _user;
            task = _task;
            Method(out hieroglyphs, out hieroglyph);
        }

        private void Method(out List<Hieroglyph>hieroglyphs, out Hieroglyph hieroglyph)
        {
            try
            {
                //чего-то не хватает
                //System.Threading.Thread.Sleep(10000);

                using (var context = new Context())
                {
                    hieroglyph = null;
                    hieroglyphs = new List<Hieroglyph>();
                    if (task == 1)
                    {
                        if(context.Favourites.Where(h => h.TaskOneRight == false
                    && h.UserMail == user.Email).FirstOrDefault() != null)
                        foreach (var hierogl in context.Favourites.Where(h => h.TaskOneRight == false
                    && h.UserMail == user.Email).OrderBy(X => Guid.NewGuid()).Take(4).ToList())
                        {
                            hieroglyphs.Add(context.Hieroglyphs.FirstOrDefault(h => h.ChineseWord == hierogl.Hieroglyph));
                        }
                    }
                    if (task == 2)
                    {
                        if(context.Favourites.Where(h => h.TaskTwoRight == false
                    && h.UserMail == user.Email).FirstOrDefault() != null)
                        foreach (var hierogl in context.Favourites.Where(h => h.TaskTwoRight == false
                    && h.UserMail == user.Email).OrderBy(X => Guid.NewGuid()).Take(4).ToList())
                        {
                            hieroglyphs.Add(context.Hieroglyphs.FirstOrDefault(h => h.ChineseWord == hierogl.Hieroglyph));
                        }
                    }
                    if (task == 3)
                    {
                        if (context.Favourites.Where(h => h.TaskThreeRight == false
                     && h.UserMail == user.Email).FirstOrDefault() != null)
                        foreach (var hierogl in context.Favourites.Where(h => h.TaskThreeRight == false
                    && h.UserMail == user.Email).OrderBy(X => Guid.NewGuid()).Take(4).ToList())
                        {
                            hieroglyphs.Add(context.Hieroglyphs.FirstOrDefault(h => h.ChineseWord == hierogl.Hieroglyph));
                        }
                    }
                    if (hieroglyphs.Count < 4)
                    {
                        foreach (var hierogl in context.Favourites.Where(h => h.UserMail == user.Email).
                            OrderBy(X => Guid.NewGuid()).Take(4 - hieroglyphs.Count).ToList())
                        {
                            hieroglyphs.Add(context.Hieroglyphs.FirstOrDefault(h => h.ChineseWord == hierogl.Hieroglyph));
                        }
                    }
                    foreach (var h in hieroglyphs.OrderBy(X => Guid.NewGuid()).Take(1))
                    {
                        hieroglyph = h;
                    }
                    if (task == 2)
                    {
                        VarOne.Content = hieroglyphs[0].ChineseWord;
                        VarTwo.Content = hieroglyphs[1].ChineseWord;
                        VarThree.Content = hieroglyphs[2].ChineseWord;
                        VarFour.Content = hieroglyphs[3].ChineseWord;
                        Question.Text = hieroglyph.Translation;
                    }
                    if (task == 1)
                    {
                        VarOne.Content = hieroglyphs[0].Pinyin;
                        VarTwo.Content = hieroglyphs[1].Pinyin;
                        VarThree.Content = hieroglyphs[2].Pinyin;
                        VarFour.Content = hieroglyphs[3].Pinyin;
                        Question.Text = hieroglyph.ChineseWord;
                    }
                    if (task == 3)
                    {
                        VarOne.Content = hieroglyphs[0].Translation;
                        VarTwo.Content = hieroglyphs[1].Translation;
                        VarThree.Content = hieroglyphs[2].Translation;
                        VarFour.Content = hieroglyphs[3].Translation;
                        Question.Text = hieroglyph.ChineseWord;
                    };
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check", "Something's wrong with the DataBase!");
                throw;
            }
        }

        private void RightAnswers()
        {
            howManyRightAnsweres += 1;
            try
            {
                using (var context = new Context())
                {
                    var h = context.Favourites.FirstOrDefault(f => f.UserMail == user.Email && f.Hieroglyph == hieroglyph.ChineseWord);
                    h.TaskOneRight = true;
                    context.Favourites.AddOrUpdate(h);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check", "Something's wrong with the DataBase!");
                throw;
            }
        }

        private void VarOne_Click(object sender, RoutedEventArgs e)
        {
            amountOfQuestionsPassed += 1;
            if (hieroglyph.ChineseWord == VarOne.Content.ToString() || hieroglyph.Pinyin == VarOne.Content.ToString()
                || hieroglyph.Translation == VarOne.Content.ToString())
            {
                RightAnswers();
                VarOne.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                VarOne.Background = new SolidColorBrush(Colors.Red);
            }
            if (amountOfQuestionsPassed < 20)
            {
                Task.Delay(10000);
                VarOne.Background = new SolidColorBrush(Colors.Bisque);
                Method(out hieroglyphs, out hieroglyph);
            }
            else
            {
                //Task.Delay(10000);
                var congratulation = new Congratulation(howManyRightAnsweres, user);
                congratulation.Show();
                this.Close();
            }
        }

        private void VarTwo_Click(object sender, RoutedEventArgs e)
        {
            amountOfQuestionsPassed += 1;
            if (hieroglyph.ChineseWord == VarTwo.Content.ToString() || hieroglyph.Pinyin == VarTwo.Content.ToString()
                || hieroglyph.Translation == VarTwo.Content.ToString())
            {
                RightAnswers();
                VarTwo.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                VarTwo.Background = new SolidColorBrush(Colors.Red);
            }
            if (amountOfQuestionsPassed < 20)
            {
                Task.Delay(10000);
                VarTwo.Background = new SolidColorBrush(Colors.Bisque);
                Method(out hieroglyphs, out hieroglyph);
            }
            else
            {
                Task.Delay(10000);
                var congratulation = new Congratulation(howManyRightAnsweres, user);
                congratulation.Show();
                this.Close();
            }
        }

        private void VarThree_Click(object sender, RoutedEventArgs e)
        {
            amountOfQuestionsPassed += 1;
            if (hieroglyph.ChineseWord == VarThree.Content.ToString() || hieroglyph.Pinyin == VarThree.Content.ToString()
                || hieroglyph.Translation == VarThree.Content.ToString())
            {
                RightAnswers();
                VarThree.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                VarThree.Background = new SolidColorBrush(Colors.Red);
            }
            if (amountOfQuestionsPassed < 20)
            {
                Task.Delay(10000);
                VarThree.Background = new SolidColorBrush(Colors.Bisque);
                Method(out hieroglyphs, out hieroglyph);
            }
            else
            {
                Task.Delay(10000);
                var congratulation = new Congratulation(howManyRightAnsweres, user);
                congratulation.Show();
                this.Close();
            }
        }

        private void VarFour_Click(object sender, RoutedEventArgs e)
        {
            amountOfQuestionsPassed += 1;
            if (hieroglyph.ChineseWord == VarFour.Content.ToString() || hieroglyph.Pinyin == VarFour.Content.ToString()
                || hieroglyph.Translation == VarFour.Content.ToString())
            {
                RightAnswers();
                VarFour.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                VarFour.Background = new SolidColorBrush(Colors.Red);
            }
            if (amountOfQuestionsPassed < 20)
            {
                Task.Delay(10000); ;
                VarFour.Background = new SolidColorBrush(Colors.Bisque);
                Method(out hieroglyphs, out hieroglyph);
            }
            else
            {
                Task.Delay(10000);
                var congratulation = new Congratulation(howManyRightAnsweres, user);
                congratulation.Show();
                this.Close();
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            (new TaskChoosing(user)).Show();
            this.Close();
        }
    }
}
