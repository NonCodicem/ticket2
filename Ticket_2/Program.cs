using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket("Ben", Betaalwijze.cash);

            Product appel = new Product("appels", 1.60, "P12345");
            Product peer = new Product("peren", 1.80, "P12845");
            Product banaan = new Product("bananen", 2.60, "P14345");

            ticket.Producten.Add(appel);
            ticket.Producten.Add(peer);
            ticket.Producten.Add(banaan);


            ticket.DrukTicket();
            Console.ReadKey();
        }
    }
}
