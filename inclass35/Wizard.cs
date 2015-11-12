using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass35
{
    class  Wizard : parent
    {
        protected int backfirePercent;
        public Wizard(int health, int attack, int intel, string name)
            : base(health, attack, intel, name)
        {
            backfirePercent = 100 / intel;
        }

        public void setIntel(int modify)
        {
            intel += modify;
            backfirePercent = 100 / intel;
        }

        public override string ToString()
        {
            return base.ToString() + " Backfire %: " + backfirePercent;
        }
    }
}
