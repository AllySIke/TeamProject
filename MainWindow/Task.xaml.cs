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
using TeamProject;
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
        Hieroglyph hieroglyph;
        List<Hieroglyph> hieroglyphs;
        int task;

        public Task(int _task, User _user)
        {
            InitializeComponent();
            user = _user;
            task = _task;
            if (task == 1)
            {
                Method(1, out hieroglyphs, out hieroglyph);
            }
            if (task == 2)
            {
                Method(2, out hieroglyphs, out hieroglyph);
            }
            if (task == 3)
            {
                Method(3,out hieroglyphs, out hieroglyph);
            }
        }

        private void Method(int task, out List<Hieroglyph>hieroglyphs, out Hieroglyph hieroglyph)
        {
            using (var context = new Context())
            {
                hieroglyphs = null;
                foreach (var hierogl in context.Favourites.Where(h => h.TaskOneRight == false
                && h.UserMail == user).OrderBy(X => Guid.NewGuid()).Take(4).ToList())
                {
                    hieroglyphs.Add(context.Hieroglyphs.FirstOrDefault(h => h.ChineseWord == hierogl.Hieroglyph.ChineseWord));
                }
                VarOne.Content = hieroglyphs[0].ChineseWord;
                VarTwo.Content = hieroglyphs[1].ChineseWord;
                VarThree.Content = hieroglyphs[2].ChineseWord;
                VarFour.Content = hieroglyphs[3].ChineseWord;
                hieroglyph = hieroglyphs.OrderBy(X => Guid.NewGuid()).Take(1) as Hieroglyph;
                Question.Text = hieroglyph.Translation;
            }
        }
        private void VarOne_Click(object sender, RoutedEventArgs e)
        {
            amountOfQuestionsPassed += 1;
            if (hieroglyph.ChineseWord == VarOne.Content.ToString() || hieroglyph.Pinyin == VarOne.Content.ToString()
                || hieroglyph.Translation == VarOne.Content.ToString())
            {
                howManyRightAnsweres += 1;
                using (var context = new Context())
                {
                    var h = context.Favourites.FirstOrDefault(f => f.UserMail == user && f.Hieroglyph == hieroglyph);
                    context.Favourites.Remove(h);
                    h.TaskOneRight = true;
                    context.Favourites.Add(h);
                    context.SaveChanges();
                }
            }
            else
            {
                //показать что ответ неверный???????????
            }
            if (amountOfQuestionsPassed < 20)
            {
                if (task == 1)
                {
                    Method(1, out hieroglyphs, out hieroglyph);
                }
                if (task == 2)
                {
                    Method(2, out hieroglyphs, out hieroglyph);
                }
                if (task == 3)
                {
                    Method(3, out hieroglyphs, out hieroglyph);
                }
            }
            else
            {
                //ноыое окно????????????????
            }
        }

        private void VarTwo_Click(object sender, RoutedEventArgs e)
        {
            amountOfQuestionsPassed += 1;
            if (hieroglyph.ChineseWord == VarTwo.Content.ToString() || hieroglyph.Pinyin == VarTwo.Content.ToString()
                || hieroglyph.Translation == VarTwo.Content.ToString())
            {
                howManyRightAnsweres += 1;
                using (var context = new Context())
                {
                    var h = context.Favourites.FirstOrDefault(f => f.UserMail == user && f.Hieroglyph == hieroglyph);
                    context.Favourites.Remove(h);
                    h.TaskTwoRight = true;
                    context.Favourites.Add(h);
                    context.SaveChanges();
                }
            }
            else
            {
                //показать что ответ неверный???????????
            }
            if (amountOfQuestionsPassed < 20)
            {
                if (task == 1)
                {
                    Method(1, out hieroglyphs, out hieroglyph);
                }
                if (task == 2)
                {
                    Method(2, out hieroglyphs, out hieroglyph);
                }
                if (task == 3)
                {
                    Method(3, out hieroglyphs, out hieroglyph);
                }
            }
            else
            {
                //ноыое окно????????????????
            }
        }

        private void VarThree_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void VarFour_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            //спросить у юзера уверен ли он выйти/закончить
            (new TaskChoosing(user)).Show();
            this.Close();
        }
    }
}
