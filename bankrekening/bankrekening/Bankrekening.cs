using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankrekening
{
    class Bankrekening
    {
        //Fields
        private int rekeningnummer;
        private string naam;
        private int saldo; //het saldo in hele centen
        private static int volgendeVrijeRekeningnummer = 2001;

        //Constructor
        public Bankrekening (string naam)
        {
            this.naam = naam;
            saldo = 0;
            rekeningnummer = volgendeVrijeRekeningnummer;

            volgendeVrijeRekeningnummer++;
        }

        //Properties
        public int Rekeningnummer
        {
            get { return rekeningnummer; }
        }

        public string Naam
        {
            get { return naam; }
        }

        public int Saldo
        {
            get { return saldo;}
            private set { saldo = value; }
        }

        // Methods
        public void NeemOp(int bedrag)
        {
            // bedrag in hele centen, negatieve bedragen worden genegeerd.
            if (bedrag > 0)
            {
                if (saldo >= bedrag) {
                    saldo -= bedrag;
                }
            }
        }

        public void Stort(int bedrag)
        {
            // bedrag in hele centen, negatieve bedragen worden genegeerd.
            if (bedrag > 0)
            {
                saldo += bedrag;
            }
        }


        public string MaakOver(Bankrekening andereRekening, int bedrag)
        {
            // bedrag in hele centen, negatieve bedragen worden genegeerd.
            if (saldo > 0)
            {
                if (saldo >= bedrag)
                {
                    andereRekening.Saldo += bedrag;
                    saldo -= bedrag;
                    return $"Bedrag overgemaakt: {bedrag} naar {andereRekening.Naam}";
                }
                else
                {
                    return "Saldo niet toereikend";
                }

            }
            else {
                return "Vul een geldig bedrag in";
            }
        }

    }
}
