using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    public class Word
    {
        private string thisWord = "";

        public Word(string word) { thisWord = word; }

        public static implicit operator string(Word v)
        {
            return v.thisWord;
        }

        public static implicit operator Word(string v)
        {
            return new Word(v);
        }
    }
}
