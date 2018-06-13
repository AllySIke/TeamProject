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
                        ChineseWord = "你",
                        Pinyin = "nǐ",
                        Translation = "you"
                    },
                     new Hieroglyph
                     {
                        ChineseWord = "你们",
                        Pinyin = "nǐmen",
                        Translation = "you (pl.)"
                     },
                     new Hieroglyph
                     {
                        ChineseWord = "他们",
                        Pinyin = "tāmen",
                        Translation = "they (male+female / male, pl.)"
                     },
                     new Hieroglyph
                     {
                        ChineseWord = "她们",
                        Pinyin = "tāmen",
                        Translation = "they (females, pl.))"
                     },
                     new Hieroglyph
                     {
                        ChineseWord = "这 (这儿)",
                        Pinyin = "zhè ( zhèr)",
                        Translation = "here, this"
                     },
                     new Hieroglyph
                     {
                        ChineseWord = "那 (那儿)",
                        Pinyin = "nà (nàr)",
                        Translation = "	there, that"
                     },
                     new Hieroglyph
                     {
                        ChineseWord = "哪（哪儿）",
                        Pinyin = "nǎ (nǎr)",
                        Translation = "	where"
                     },
                     new Hieroglyph
                     {
                        ChineseWord = "谁",
                        Pinyin = "shuí",
                        Translation = "who"
                     },
                     new Hieroglyph
                     {
                        ChineseWord = "什么",
                        Pinyin = "shén me",
                        Translation = "what, why"
                     },
                     new Hieroglyph
                     {
                        ChineseWord = "多少",
                        Pinyin = "duōshǎo",
                        Translation = "how many, how much"
                     },
                      new Hieroglyph
                      {
                        ChineseWord = "几",
                        Pinyin = "jǐ",
                        Translation = "a few, how many"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "怎么",
                        Pinyin = "zěnme",
                        Translation = "how"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "怎么样",
                        Pinyin = "zěnmeyàng",
                        Translation = "how about"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "一",
                        Pinyin = "yī",
                        Translation = "one"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "二",
                        Pinyin = "èr",
                        Translation = "two"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "三",
                        Pinyin = "sān",
                        Translation = "three"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "四",
                        Pinyin = "sì",
                        Translation = "four"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "五",
                        Pinyin = "wǔ",
                        Translation = "five"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "六",
                        Pinyin = "liù",
                        Translation = "six"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "七",
                        Pinyin = "qī",
                        Translation = "seven"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "八",
                        Pinyin = "bā",
                        Translation = "eight"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "九",
                        Pinyin = "jiǔ",
                        Translation = "nine"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "十",
                        Pinyin = "shí",
                        Translation = "ten"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "零",
                        Pinyin = "líng",
                        Translation = "zero"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "个",
                        Pinyin = "gè",
                        Translation = "one, a, an"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "岁",
                        Pinyin = "suì",
                        Translation = "year"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "本",
                        Pinyin = "běn",
                        Translation = "volume"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "些",
                        Pinyin = "xiē",
                        Translation = "some"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "块",
                        Pinyin = "kuài",
                        Translation = "piece"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "不",
                        Pinyin = "bù",
                        Translation = "no"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "没",
                        Pinyin = "méi",
                        Translation = "no"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "很",
                        Pinyin = "hěn",
                        Translation = "quite, very"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "太",
                        Pinyin = "tài",
                        Translation = "too"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "都",
                        Pinyin = "dōu",
                        Translation = "all"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "和",
                        Pinyin = "hé",
                        Translation = "and"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "在",
                        Pinyin = "zài",
                        Translation = "in, at"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "的",
                        Pinyin = "bù",
                        Translation = "a particle linking adjectives to nouns"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "了",
                        Pinyin = "le",
                        Translation = "a particle of the past tense"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "吗",
                        Pinyin = "ma",
                        Translation = "a question particle(yes/no questions)"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "呢",
                        Pinyin = "ne",
                        Translation = "a question particle(W/H questions)"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "喂",
                        Pinyin = "wèi",
                        Translation = "hello"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "家",
                        Pinyin = "jiā",
                        Translation = "home"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "学校",
                        Pinyin = "xuéxiào",
                        Translation = "school"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "饭店",
                        Pinyin = "fàndiàn",
                        Translation = "restaurant"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "商店",
                        Pinyin = "shāngdiàn",
                        Translation = "store"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "医院",
                        Pinyin = "yīyuàn",
                        Translation = "hospital"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "火车站",
                        Pinyin = "huǒchēzhàn",
                        Translation = "train station"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "中国",
                        Pinyin = "zhōng guó",
                        Translation = "China"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "北京",
                        Pinyin = "běijīng",
                        Translation = "Beijing"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "上",
                        Pinyin = "shàng",
                        Translation = "up"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "下",
                        Pinyin = "xià",
                        Translation = "down"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "前面",
                        Pinyin = "qiánmiàn",
                        Translation = "front"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "后面",
                        Pinyin = "hòumiàn",
                        Translation = "behind"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "里面",
                        Pinyin = "lǐmiàn",
                        Translation = "inside"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "今天",
                        Pinyin = "jīntiān",
                        Translation = "today"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "明天",
                        Pinyin = "míngtiān",
                        Translation = "tomorrow"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "昨天",
                        Pinyin = "zuótiān",
                        Translation = "yesterday"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "上午",
                        Pinyin = "shàngwǔ",
                        Translation = "morning"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "中午",
                        Pinyin = "zhōngwǔ",
                        Translation = "noon"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "下午",
                        Pinyin = "xiàwǔ",
                        Translation = "afternoon"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "年",
                        Pinyin = "nián",
                        Translation = "year"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "月",
                        Pinyin = "yuè",
                        Translation = "month"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "日",
                        Pinyin = "rì",
                        Translation = "day"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "星期",
                        Pinyin = "xīngqī",
                        Translation = "week"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "点",
                        Pinyin = "diǎn",
                        Translation = "hour"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "分钟",
                        Pinyin = "fēnzhōng",
                        Translation = "minute"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "现在",
                        Pinyin = "xiànzài",
                        Translation = "now"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "时候",
                        Pinyin = "shíhou",
                        Translation = "time"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "爸爸",
                        Pinyin = "bàba",
                        Translation = "father"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "妈妈",
                        Pinyin = "māma",
                        Translation = "mother"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "儿子",
                        Pinyin = "érzi",
                        Translation = "son"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "女儿",
                        Pinyin = "nǚér",
                        Translation = "daughter"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "老师",
                        Pinyin = "lǎoshī",
                        Translation = "teacher"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "学生",
                        Pinyin = "xuéshēng",
                        Translation = "student"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "同学",
                        Pinyin = "tóngxué",
                        Translation = "shoolmate"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "朋友",
                        Pinyin = "péngyou",
                        Translation = "friend"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "医生",
                        Pinyin = "yīshēng",
                        Translation = "doctor"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "先生",
                        Pinyin = "xiānsheng",
                        Translation = "sir"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "小姐",
                        Pinyin = "xiǎojiě",
                        Translation = "Miss"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "衣服",
                        Pinyin = "yīfu",
                        Translation = "cloth"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "水",
                        Pinyin = "xiānsheng",
                        Translation = "water"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "菜",
                        Pinyin = "cài",
                        Translation = "vegetable"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "米饭",
                        Pinyin = "mǐfàn",
                        Translation = "rice"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "水果",
                        Pinyin = "shuǐguǒ",
                        Translation = "fruit"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "苹果",
                        Pinyin = "píngguǒ",
                        Translation = "apple"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "茶",
                        Pinyin = "chá",
                        Translation = "tea"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "杯子",
                        Pinyin = "bēizi",
                        Translation = "cup"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "钱",
                        Pinyin = "qián",
                        Translation = "money"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "飞机",
                        Pinyin = "fēijī",
                        Translation = "airplane"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "出租车",
                        Pinyin = "chūzūchē",
                        Translation = "taxi"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "电视",
                        Pinyin = "diànshì",
                        Translation = "television"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "电脑",
                        Pinyin = "diànnǎo",
                        Translation = "computer"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "电影",
                        Pinyin = "diànyǐng",
                        Translation = "movie"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "天气",
                        Pinyin = "tiānqì",
                        Translation = "weather"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "猫",
                        Pinyin = "māo",
                        Translation = "cat"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "狗",
                        Pinyin = "gǒu",
                        Translation = "dog"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "东西",
                        Pinyin = "dōngxi",
                        Translation = "thing"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "人",
                        Pinyin = "rén",
                        Translation = "person"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "名字",
                        Pinyin = "míngzi",
                        Translation = "name"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "书",
                        Pinyin = "shū",
                        Translation = "book"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "汉语",
                        Pinyin = "hànyǔ",
                        Translation = "mandarin Chinese"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "字",
                        Pinyin = "zì",
                        Translation = "character"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "桌子",
                        Pinyin = "zhuōzi",
                        Translation = "desk"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "椅子",
                        Pinyin = "yǐzi",
                        Translation = "chair"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "谢谢",
                        Pinyin = "xièxie",
                        Translation = "thank"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "不客气",
                        Pinyin = "búkèqì",
                        Translation = "you are welcome"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "再见",
                        Pinyin = "zàijiàn",
                        Translation = "good-bye"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "请",
                        Pinyin = "qǐng",
                        Translation = "please"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "对不起",
                        Pinyin = "duìbùqǐ",
                        Translation = "sorry"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "没关系",
                        Pinyin = "méiguānxì",
                        Translation = "It doesn’t matter"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "是",
                        Pinyin = "shì",
                        Translation = "be (am, is, are)"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "有",
                        Pinyin = "yǒu",
                        Translation = "have"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "看",
                        Pinyin = "kàn",
                        Translation = "look"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "听",
                        Pinyin = "tīng",
                        Translation = "listen"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "说话",
                        Pinyin = "shuōhuà",
                        Translation = "speak"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "读",
                        Pinyin = "dú",
                        Translation = "read"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "写",
                        Pinyin = "xiě",
                        Translation = "write"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "看见",
                        Pinyin = "kànjiàn",
                        Translation = "see"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "叫",
                        Pinyin = "jiào",
                        Translation = "call"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "来",
                        Pinyin = "lái",
                        Translation = "come"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "回",
                        Pinyin = "huí",
                        Translation = "return"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "去",
                        Pinyin = "qù",
                        Translation = "go"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "吃",
                        Pinyin = "chī",
                        Translation = "eat"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "喝",
                        Pinyin = "hē",
                        Translation = "drink"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "睡觉",
                        Pinyin = "shuìjiào",
                        Translation = "sleep"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "打电话",
                        Pinyin = "dǎdiànhuà",
                        Translation = "call up"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "做",
                        Pinyin = "zuò",
                        Translation = "do"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "买",
                        Pinyin = "mǎi",
                        Translation = "buy"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "开",
                        Pinyin = "kāi",
                        Translation = "open"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "坐",
                        Pinyin = "zuò",
                        Translation = "sit"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "住",
                        Pinyin = "zhù",
                        Translation = "live"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "学习",
                        Pinyin = "xuéxí",
                        Translation = "study"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "工作",
                        Pinyin = "gōngzuò",
                        Translation = "work"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "下雨",
                        Pinyin = "xiàyǔ",
                        Translation = "rain"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "爱",
                        Pinyin = "ài",
                        Translation = "love"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "喜欢",
                        Pinyin = "xǐhuān",
                        Translation = "love, like"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "想",
                        Pinyin = "xiǎng",
                        Translation = "want"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "认识",
                        Pinyin = "rènshi",
                        Translation = "know"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "会",
                        Pinyin = "huì",
                        Translation = "can"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "能",
                        Pinyin = "néng",
                        Translation = "can, be able to"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "好",
                        Pinyin = "hǎo",
                        Translation = "good"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "大",
                        Pinyin = "dà",
                        Translation = "big"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "小",
                        Pinyin = "xiǎo",
                        Translation = "small"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "多",
                        Pinyin = "duō",
                        Translation = "many, much"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "少",
                        Pinyin = "shǎo",
                        Translation = "few, little"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "冷",
                        Pinyin = "lěng",
                        Translation = "cold"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "热",
                        Pinyin = "rè",
                        Translation = "hot"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "高兴",
                        Pinyin = "gāoxìng",
                        Translation = "happy"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "漂亮",
                        Pinyin = "piàoliàng",
                        Translation = "beautiful"
                      },
                      new Hieroglyph
                      {
                        ChineseWord = "她",
                        Pinyin = "tā",
                        Translation = "she, her"
                      }
                    };
            foreach (var h in Hs)
                {
                    context.Hieroglyphs.AddOrUpdate(u => u.ChineseWord, h);
                }
                context.SaveChanges();
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
