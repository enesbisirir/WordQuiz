using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordQuiz
{
    static class Extensions
    {
        /// <summary>
        /// Populates <see cref="CheckedListBox"/> with all units from database.
        /// </summary>
        public static void Populate(this CheckedListBox clb)
        {
            UnitHolder units = new UnitHolder();
            units.FillEverythingFromDatabase();
            foreach (Unit unit in units)
            {
                clb.Items.Add(unit);
            }
        }

        /// <summary>
        /// Returns a <see cref="UnitHolder"/> containing currently checked <see cref="Unit"/>s.
        /// </summary>
        public static UnitHolder CheckedUnits(this CheckedListBox clb)
        {
            UnitHolder units = new UnitHolder();
            foreach (Unit unit in clb.CheckedItems)
            {
                units.Add(unit);
            }
            return units;
        }

        /// <summary>
        /// Returns number of checked units.
        /// </summary>
        public static int GetCheckedUnitCount(this CheckedListBox clb)
        {
            int unitCount = 0;
            foreach (Unit unit in clb.CheckedItems)
            {
                unitCount++;
            }
            return unitCount;
        }
    }
}
