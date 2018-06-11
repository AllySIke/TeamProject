using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    public class Favourite
    {
        public int Id { get; set; }
        public virtual string UserMail { get; set; }
        public virtual string Hieroglyph { get; set; }
        public int TaskOneRight { get; set; }
        public int TaskTwoRight { get; set; }
        public int TaskThreeRight { get; set; }
        //тут нужно какое-то паблик виртуал и ссылку на юзера гг Бабнича поспрашиваю
    }
}
