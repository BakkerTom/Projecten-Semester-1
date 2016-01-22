using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite_Test
{
    class Film
    {
        //Fields
        private string titel;
        private int uitgavejaar;

        public Film(string titel, int uitgavejaar)
        {
            this.titel = titel;
            this.uitgavejaar = uitgavejaar;
        }

        public string Titel {
            get {
                return this.titel;
            }    
        }

        public int Uitgavejaar {
            get {
                return this.uitgavejaar;
            }
        }

        public override string ToString()
        {
            return titel + " (" + uitgavejaar + ")";
        }
    }
}
