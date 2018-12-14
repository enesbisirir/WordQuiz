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
        /// <summary>
        /// Updates <see cref="selectedUnits"/> and <see cref="selectedWords"/> according to given <see cref="UnitHolder"/>.
        /// </summary>
        public static void UpdateGameHolders(UnitHolder units)
        {
            UpdateCheckedUnits(units);
            UpdateSelectedWords();
        }

        /// <summary>
        /// Clears <see cref="selectedUnits"/> and sets it to given <see cref="UnitHolder"/>
        /// </summary>
        public static void UpdateCheckedUnits(UnitHolder units)
        {
            if (Current.selectedUnits != null)
            {
                Current.selectedUnits.Clear();
            }
            Current.selectedUnits = units;
        }
        
        /// <summary>
        /// Clears <see cref="selectedWords"/> and updates it with words in currently selected units.
        /// </summary>
        public static void UpdateSelectedWords()
        {
            if(Current.selectedWords != null)
            {
                Current.selectedWords.Clear();
            }
            Current.selectedWords.Fill(Current.selectedUnits);
        }
        

        private static Game Current = new Game();
        private WordHolder selectedWords = new WordHolder();
        private UnitHolder selectedUnits = new UnitHolder();
        public static WordHolder SelectedWords { get { return Current.selectedWords; } }
        public static UnitHolder SelectedUnits { get { return Current.selectedUnits; } }
    }
}
