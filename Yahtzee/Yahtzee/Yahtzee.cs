using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Yahtzee
    {
        int[] waardes;
        private Random d;

        public Yahtzee()
        {
            d = new Random(); 
        }

        public void doeWorp()
        {
            waardes = new int[5];

            for (int i = 0; i < 5; i++)
            {
                waardes[i] = d.Next(1, 7);
            }
        }

        public override string ToString()
        {
            string result = "";

            foreach (int waarde in waardes) {
                result += waarde.ToString() + ", ";
            }

            return result;
        }
    }
}
