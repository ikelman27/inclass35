using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass35
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior war = new Warrior(20, 10, 23, "bob");
            Wizard wiz = new Wizard(10, 32, 12, "fff");
            Rouge rou = new Rouge(12, 42, 13, "IDK");

            Console.WriteLine(war.ToString());
            Console.WriteLine(wiz.ToString());
            Console.WriteLine(rou.ToString());
            war.setIntel(5);
            wiz.setIntel(-3);
            rou.setIntel(14);
            Console.WriteLine(war.ToString());
            Console.WriteLine(wiz.ToString());
            Console.WriteLine(rou.ToString());
        }
    }
}
