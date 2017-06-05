using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    public sealed class BeagleText : IEnumerable
    {
        private List<Word> words = new List<Word>();

        public BeagleText(params Word[] addWords)
        {
            foreach (Word w in addWords)
            {
                words.Add(w);
            }
        }

        /// <summary>
        /// Adds a word to a text.
        /// </summary>
        /// <param name="w">The word to add</param>
        public void AddWord(Word w)
        {
            words.Add(w);
        }

        /// <summary>
        /// Gets a word from this Text.
        /// </summary>
        /// <param name="index">The null based index of the word.</param>
        /// <returns>Returns the found word.</returns>
        public Word GetWord(int index)
        {
            return words[index];
        }

        /// <summary>
        /// Find a specific Word if existing.
        /// </summary>
        /// <param name="word">Specific word.</param>
        /// <returns>Returns the found word.</returns>
        public Word FindWord(string word)
        {
            foreach (Word w in words)
            {
                if (w == word)
                    return w;
            }

            return "NO MATCH FOUND";
        }

        /// <summary>
        /// Removes a word if evailable.
        /// </summary>
        /// <param name="word">The Word to remove.</param>
        /// <returns>Returns the Text without the removed words.</returns>
        public BeagleText RemoveWord(Word word)
        {
            foreach (Word w in words)
            {
                if (w == word)
                    words.Remove(w);
            }
            return this;
        }

        public string ConvertBeagleText()
        {
            string c = "";
            foreach (Word w in words)
            {
                c += w;
            }
            return c;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Word w in words)
                yield return w;
        }

        public static implicit operator string(BeagleText v)
        {
            return v.ConvertBeagleText();
        }
    }
}
