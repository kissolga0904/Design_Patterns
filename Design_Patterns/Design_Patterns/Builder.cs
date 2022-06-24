using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public class Warrior
    {
        private string kard1, kard2;
        private string pajzs;
        private List<string> hatizsak = new List<string>();

        public class WarriorBuilder
        {
            Warrior w = new Warrior();
            public WarriorBuilder setKard1(string kard1)
            {
                w.kard1 = kard1;
                return this;
            }
            public WarriorBuilder setKard2(string kard2)
            {
                w.kard2 = kard2;
                return this;
            }
            public WarriorBuilder setPajzs(string pajzs)
            {
                w.pajzs = pajzs;
                return this;
            }
            public WarriorBuilder beteszHatizsakba(string targy)
            {
                w.hatizsak.Add(targy);
                return this;
            }
            public Warrior getWarrior()
            {
                return w;
            }

        }
    }
}
