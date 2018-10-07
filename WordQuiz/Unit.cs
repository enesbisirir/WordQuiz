using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordQuiz
{
    class Unit
    {
        public string Name { get; set; }
        public int UnitId { get; set; }

        public Unit(int id, string name)
        {
            Name = name;
            UnitId = id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
