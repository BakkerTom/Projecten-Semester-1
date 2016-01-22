using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trekking
{
    class Trekking
    {
        //Fields
        private int[] getallen;
        private Random random;

        //Properties
        public int MaxWaarde { get; private set; }
        public int AantalGetrokken { get; private set; }
        public int AantalGewenst { get; private set; }
        public bool IsTenEinde { get; private set; }

        public Trekking(int maxWaarde, int aantalGewenst)
        {
            MaxWaarde = maxWaarde;
            AantalGewenst = aantalGewenst;
            AantalGetrokken = 0;
            IsTenEinde = false;

            random = new Random();
            getallen = new int[aantalGewenst];
        }

        public void TrekGetal()
        {
            //Loopt zolang de trekking nog niet ten einde is
            if (!IsTenEinde)
            {
                //Wanneer het aantal getrokken hoger is dan het aantalgewenst wordt IsTenEinde true, waardoor de loop stopt
                if (AantalGetrokken >= AantalGewenst)
                {
                    IsTenEinde = true;
                }

                //Een nieuw random nummer wordt gegenereerd
                int trekking = random.Next(MaxWaarde);

                //De trekking wordt opgeslagen in de array getallen en het AantalGetrokken wordt met 1 verhoogd
                getallen[AantalGetrokken] = trekking;
                AantalGetrokken++;
            }
        }

        public int GeefGetal(int index)
        {
            return getallen[index];
        }

        public void Sort()
        {
            Array.Sort(getallen);
        }
    }
}
