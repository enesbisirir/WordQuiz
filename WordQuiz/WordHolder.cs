using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordQuiz
{
    class WordHolder : IEnumerable
    {
        private List<Word> words;

        public WordHolder()
        {
            words = new List<Word>();
        }

        public Word GetWord(int i)
        {
            return words[i];
        }

        public void FillEverythingFromDatabase()
        {
            DbManager.FillWordHolder(this);
        }

        public void InsertIntoDatabase()
        {
            foreach(Word word in words)
            {
                word.InsertIntoDatabase();
            }
        }

        public void Add(Word word)
        {
            words.Add(word);
        }

        public void Add(string eng, string esp, int unt)
        {
            words.Add(new Word(eng, esp, unt));
        }

        public IEnumerator GetEnumerator()
        {
            return words.GetEnumerator();
        }
    }
}
