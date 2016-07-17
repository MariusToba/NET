using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facemsoft4
{
    public class Word
    {
        string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        int difficulty;

        public int Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        public Word()
        {
            text = "Spanzuratoarea";
        }
    }
}
