using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    public class Program
    {
        public void Update()
        {
            using (var context = new Context())
            {
                List<Hieroglyph> Hs = new List<Hieroglyph>()
                {
                    new Hieroglyph
                    {
                        ChineseWord = "他",
                        Pinyin = "tā",
                        Translation = "he"
                    },
                    new Hieroglyph
                    {
                        ChineseWord = "我",
                        Pinyin = "wǒ",
                        Translation = "me"
                    },
                    new Hieroglyph
                    {
                        ChineseWord = "我们",
                        Pinyin = "wǒmen",
                        Translation = "we"
                    },
                    new Hieroglyph
                    {
                        ChineseWord = "你们",
                        Pinyin = "nǐmen",
                        Translation = "you (pl.)"
                    }
                };
                foreach (var h in Hs)
                {
                    context.Hieroglyphs.AddOrUpdate(h);
                }
                context.SaveChanges();
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
