using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public class Ember2: ICloneable
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
            Ember2 ember = new Ember2();
            ember.nev = this.nev;
            return ember;
        }
    }

    public class Kutya2 : ICloneable
    {
        string nev;
        string fajta;
        int labakSzama;

        Ember2 gazdi;

        public object Clone()
        {
            Kutya2 kutya = new Kutya2();
            kutya.nev = this.nev;
            kutya.fajta = this.fajta;
            kutya.labakSzama = this.labakSzama;
            kutya.gazdi = this.gazdi;
            return kutya;
        }
    }
}
