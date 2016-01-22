using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDing
{
    class Singleton1
    {
        private static int laatsteNummer = 0;
        private string naam;

        public Singleton1()
        {
            laatsteNummer++;
        }

        public int Vleugels { get; set; }

        public string Naam
        {
            get {
                return naam;
            }
            set {
                naam = value;
            }
        }

        public int Nummer
        {
            get {
                return laatsteNummer;
            }
        }

        public static string ReturnPoep()
        {
            return "Poep";
        }
        public void getInstance()
        {
                       
        }

        public static void Reset(int laatsteNummer) {
            Singleton1.laatsteNummer = laatsteNummer;
        }
    }
}
