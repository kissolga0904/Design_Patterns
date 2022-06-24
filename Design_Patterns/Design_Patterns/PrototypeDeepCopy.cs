using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public class Ember: ICloneable
    {
        string nev;

        public void setNev(string nev)
        {
            this.nev = nev;
        }
        public string getNev()
        {
            return this.nev;
        }

        public object Clone()
        {
            Ember ember = new Ember();
            ember.nev = this.nev;
            return ember;
        }
    }

    public class Kutya : ICloneable
    {
        string nev;
        string fajta;
        int labakSzama;

        Ember gazdi;

        public object Clone()
        {
            Kutya kutya = new Kutya();
            kutya.nev = this.nev;
            kutya.fajta = this.fajta;
            kutya.labakSzama = this.labakSzama;
            kutya.gazdi = (Ember)this.gazdi.Clone(); //a kasztolástól lesz Deep Copy, ShallowCopynál csak this.gazdit adunk át
            return kutya;
        }
    }
}
