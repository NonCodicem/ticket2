using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_2
{
    class Product
    {
        public string Naam { get; set; }
        public double Eenheidsprijs { get; set; }
        private string _code;

        public string Code
        {
            get { return _code; }
            set
            {
                if (!value.StartsWith("P") || value.Length != 6)
                {
                    throw new ArgumentException("Code is invalid.");
                }
                _code = value;
            }
        }

        public Product(string nm, double eenhpr, string cd)
        {
            Naam = nm;
            Eenheidsprijs = eenhpr;
            Code = cd;
        }

        public bool ValideerCode(string input)
        {
            if (!input.StartsWith("P") || input.Length != 6) return false;
            
            return true;
        }

        public override string ToString()
        {

            return $"({_code}) {Naam} {Eenheidsprijs}";
        }
    }
}
