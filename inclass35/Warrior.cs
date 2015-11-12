using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass35
{
    class Warrior: parent
    {
        protected int daysSincebath;
        public Warrior(int health, int attack, int intel, string name)
            : base(health, attack, intel, name)
        {
            daysSincebath = 100/intel;
        }

        public void setIntel(int modify)
        {
            intel += modify;
            daysSincebath = 100 / intel;
        }

        public override string ToString()
        {
            return base.ToString() + " Days since last bath: " + daysSincebath;
        }
    }
}
