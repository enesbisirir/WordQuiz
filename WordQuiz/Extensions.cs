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
        /// Populates <see cref="CheckedListBox"/> with given <see cref="UnitHolder"/>
        /// </summary>
        public static void Populate(this CheckedListBox clb, UnitHolder units)
        {
            foreach (Unit unit in units)
            {
                clb.Items.Add(unit.Name);
            }
        }
    }
}
