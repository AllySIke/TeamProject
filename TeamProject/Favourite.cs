using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamProject.UserData;

namespace TeamProject
{
    public class Favourite
    {
        public int Id { get; set; }
        //public User UserMail;
        //public Hieroglyph Hieroglyph { get; set; }
        public bool TaskOneRight { get; set; }
        public bool TaskTwoRight { get; set; }
        public bool TaskThreeRight { get; set; }

        public virtual User UserMail { get; set; }
        public virtual Hieroglyph Hieroglyph { get; set; }
        //тут нужно какое-то паблик виртуал и ссылку на юзера гг Бабнича поспрашиваю
    }
}
