using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public class Singleton: Object
    {
        private Singleton():base()
        {
            
        }
        private static Singleton instance;
        public static Singleton getInstance()
        {
            if (instance == null )
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
