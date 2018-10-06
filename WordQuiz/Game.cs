using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordQuiz
{
    class Game
    {
        public static Game Current = new Game();
        public WordHolder words = new WordHolder();
        public UnitHolder units = new UnitHolder();

        public Game()
        {
            FillEverythingFromDatabase();
        }

        private void FillEverythingFromDatabase()
        {
            words.FillEverythingFromDatabase();
            units.FillEverythingFromDatabase();
        }
    }
}
