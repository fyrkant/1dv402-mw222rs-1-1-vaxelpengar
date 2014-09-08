using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ange variabler
            double totalSumma;
            int kontanter;

            // Läs in köpsumma.
            Console.Write("Ange den totala köpsumman: ");
            totalSumma = double.Parse(Console.ReadLine());
            
            if (totalSumma < 1)
            {
                Console.WriteLine("FEL! {0:c} är mindre än 1 kr.", totalSumma);
            }

            // Läs in kontantbelopp.
            Console.Write("Mottaget kontantbelopp   : ");
            kontanter = int.Parse(Console.ReadLine());



            // Visa kvitto.

            // Visa sedlar och mynt.

        }
    }
}
