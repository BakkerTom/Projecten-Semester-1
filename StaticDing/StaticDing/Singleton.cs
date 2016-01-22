using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDing
{
    class Singleton
    {
        private static Singleton self = null;

        private Singleton() {
            System.Windows.Forms.MessageBox.Show("Constructor!");
        }

        public static Singleton getInstance()
        {
            if (self == null)
            {
                self = new Singleton();
                return self;
            }
            else {
                return self;
            }
            
        }

        public int ReturnRandom() {
            Random rdn = new Random();
            return rdn.Next(8);
        }
    }
}
