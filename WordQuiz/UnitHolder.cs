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
        public UnitHolder()
        {
            units = new List<Unit>();
        }

        public void FillEverythingFromDatabase()
        {
            DbManager.FillUnitHolder(this);
        }

        public Unit GetUnit(int i)
        {
            return units[i];
        }

        public void Clear()
        {
            units.Clear();
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

        private List<Unit> units;
        public int Count { get { return units.Count; } }
    }
}
