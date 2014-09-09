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
            // Variablerna.
            double totalSumma;
            int kontanter;
            uint  attBetala;
            double avrundningsTal;

            // Läs in totalsumman.
            while (true)
            {
                try
                {
                    Console.Write("Ange den totala köpsumman: ");
                    totalSumma = double.Parse(Console.ReadLine());

                    if (totalSumma < 1)
                    {
                        Console.WriteLine("Fel! ");
                        return;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                } 
            }

            // Läs in kontantbelopp
            Console.Write("Ange mottaget belopp: ");
            kontanter = int.Parse(Console.ReadLine());

            attBetala = (uint)Math.Round(totalSumma);
            avrundningsTal = attBetala - totalSumma;

            // Skriv ut ett kvitto.
            Console.WriteLine("Ge kunden tillbaka {o:c}.", (kontanter - totalSumma));


        }
    }
}
