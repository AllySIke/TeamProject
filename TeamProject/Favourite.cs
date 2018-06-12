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
        public string UserMail { get; set; }
        public string Hieroglyph { get; set; }
        public bool TaskOneRight { get; set; }
        public bool TaskTwoRight { get; set; }
        public bool TaskThreeRight { get; set; }
    }
}
