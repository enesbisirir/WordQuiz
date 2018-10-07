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
    }
}
