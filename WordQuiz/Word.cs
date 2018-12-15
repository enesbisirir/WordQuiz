using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordQuiz
{
    class Word
    {
        public string English { get; set; }
        public string Spanish { get; set; }
        public int UnitId { get; set; }

        public Word(string eng, string esp, int unt)
        {
            English = eng;
            Spanish = esp;
            UnitId = unt;
        }

        public void InsertIntoDatabase()
        {
            DbManager.InsertWord(this);
        }

        public override string ToString()
        {
            return string.Format("Eng: {0}, Esp: {1}, Unit: {2}", English, Spanish, UnitId.ToString());
        }
    }
}