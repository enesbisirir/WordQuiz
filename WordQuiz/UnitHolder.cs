using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordQuiz
{
    class UnitHolder : IEnumerable
    {
        private List<Unit> units;

        public UnitHolder()
        {
            units = new List<Unit>();
        }

        public void FillEverythingFromDatabase()
        {
            DbManager.FillUnitHolder(this);
        }

        public void Add(Unit unit)
        {
            units.Add(unit);
        }

        public void Add(int id, string name)
        {
            units.Add(new Unit(id, name));
        }

        public IEnumerator GetEnumerator()
        {
            return units.GetEnumerator();
        }
    }
}
