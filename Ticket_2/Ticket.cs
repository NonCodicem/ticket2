using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_2
{
    public enum Betaalwijze { banktontact, cash, visa}

    class Ticket
    {
        public List<Product> Producten { get; set; } = new List<Product>();
        public Betaalwijze BetaaldMet { get; set; }
        public string Kassier { get; set; }
        public double TotaalPrijs
        {
            get
            {
                double totaal = 0;
                foreach (var item in Producten)
                {
                    totaal += item.Eenheidsprijs;
                }
                return totaal;
            }
            
        }

        public Ticket(string nmKassier, Betaalwijze wijze)
        {
            BetaaldMet = wijze;
            Kassier = nmKassier;
        }

        public void DrukTicket()
        {
            Console.WriteLine("KASSATICKET");
            Console.WriteLine("===========");
            Console.WriteLine($"Uw kassier: {Kassier}");
            Console.WriteLine();

            foreach (var item in Producten)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("------------");
            Console.WriteLine($"Totaal {TotaalPrijs}");


        }

    }
}
