using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass35
{
    class parent
    {
        protected int health;
        protected int attack;
        protected int intel;
        private string name;
        public parent(int health, int attack, int intel, string name)
        {
            this.health = health;
            this.attack = attack;
            this.intel = intel;
            this.name = name;
        }

        public override string ToString()
        {
            return ("Name: " + name + " Health: " + health + " Attack: " + attack + " intel: " + intel);
        }
    }
}
