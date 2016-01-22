using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsOverrides
{
    class Persoon
    {
        private string naam;
        private int id;
        public string Naam { get { return this.naam; } }
        public int Id { get { return this.id; } }
        public Landen Origine { get; set; }

        public enum Landen
        {
            Nederland,
            Belgie,
            Duitsland,
            Frankrijk,
            Spanje,
            Portugal,
            Zweden,
            Griekenland
        }

        public Persoon(string Naam, int Id, Landen origine)
        {
            naam = Naam;
            id = Id;
            Origine = origine;
        }

        public override string ToString()
        {
            return this.Naam + " (" + this.Id + ", " + Origine + " )";
        }
    }
}
