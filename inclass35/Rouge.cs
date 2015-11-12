using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass35
{
    class Rouge : parent
    {
        protected int Oops;
        public Rouge(int health, int attack, int intel, string name)
            : base(health, attack, intel, name)
        {
            Oops = 100/intel;
        }

        public void setIntel(int modify)
        {
            intel += modify;
            Oops = 100 / intel;
        }

        public override string ToString()
        {
            return base.ToString() + " Oops %: " + Oops;
        }
    }
}
