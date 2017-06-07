using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    /// <summary>
    /// Stellt eine Klasse bereit, um zentral speicherbare strings darzustellen.
    /// Word ist eine Erweiterung von string und kann in den lokalen
    /// <see cref="WordStorageGlobal"/> eingetragen werden.
    /// Das hilft dabei, von überall aus auf alle im Prozess verfügbaren Words
    /// zuzugreifen.(Verwendbar für das Sammeln von Informationen über Apps etc)
    /// </summary>
    public sealed class Word
    {
        public bool dontAdd = false;

        private string thisWord = "";

        public Word(string word)
        {
            thisWord = word;
            //WordStorageGlobal.ALLWORDS.Add(word);
        }

        public Word(bool add, string word)
        {
            dontAdd = add;
            thisWord = word;
            //WordStorageGlobal.ALLWORDS.Add(word);
        }

        public static implicit operator string(Word v)
        {
            if (!v.dontAdd)
                WordStorageGlobal.ALLWORDS.Add(v);
            return v.thisWord;
        }

        public static implicit operator Word(string v)
        {
            return new Word(v);
        }
    }

    public sealed class WordStorageGlobal
    {
        public static List<Word> ALLWORDS = new List<Word>();
    }
}
