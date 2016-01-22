using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    class Persoon
    {
        public int leeftijd;
        private string achternaam;
        private string tussenvoegsel;
        private string voornaam;
        private decimal lengte = 180;

        /// <summary>
        /// Constructor voor Persoon
        /// </summary>
        /// <param name="vn">Voornaam</param>
        /// <param name="tv">Tussenvoegsel</param>
        /// <param name="an">Achternaam</param>
        public Persoon(string vn, string tv, string an)
        {
            achternaam = an;
            tussenvoegsel = tv;
            voornaam = vn; 
        }

        /// <summary>
        /// Constructor voor Persoon met lengte variabele
        /// </summary>
        /// <param name="vn">Voornaam</param>
        /// <param name="tv">Tussenvoegsel</param>
        /// <param name="an">Achternaam</param>
        /// <param name="len">Lengte</param>
        public Persoon(string vn, string tv, string an, int len)
        {
            achternaam = an;
            tussenvoegsel = tv;
            voornaam = vn;
            lengte = len;
        }
        

        /// <summary>
        /// Groet de persoon op formele wijze.
        /// </summary>
        /// <returns>Groet als string</returns>
        public string Groet()
        {
            return "Hallo " + voornaam + " " + tussenvoegsel + " " + achternaam + lengte;
        }
    }
}
