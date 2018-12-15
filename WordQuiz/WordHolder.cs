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
        public WordHolder()
        {
            words = new List<Word>();
        }

        public Word GetWord(int i)
        {
            return words[i];
        }

        public Word GetRandomWord()
        {
            int maxValue = Game.SelectedWords.Count;
            int i = Game.Random.Next(0, maxValue);
            return words[i];
        }

        public void FillEverythingFromDatabase()
        {
            DbManager.FillWordHolder(this);
        }

        public void Fill(UnitHolder units)
        {
            DbManager.FillWordHolder(this, units);
        }

        public void InsertIntoDatabase()
        {
            foreach (Word word in words)
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

        public void Remove(int i)
        {
            words.RemoveAt(i);
        }

        public void Remove(Word word)
        {
            words.Remove(word);
        }

        public void Clear()
        {
            words.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            return words.GetEnumerator();
        }

        private List<Word> words;
        public int Count { get { return words.Count; } }
    }
}
