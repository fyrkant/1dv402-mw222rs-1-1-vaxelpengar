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
                        Console.WriteLine("Fel! Totalsumman är för liten, köpet kunde inte genomföras.");
                        return;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Endast siffror, tack!");
                } 
            }

            // Läs in kontantbelopp
            while (true)
            {
                try
                {
                    Console.Write("Ange mottaget belopp     : ");
                    kontanter = int.Parse(Console.ReadLine());

                    if (kontanter < totalSumma)
                    {
                        Console.WriteLine("Fel! Pengarna räcker inte.");
                    }
                    else if (kontanter < 1)
                    {
                        Console.WriteLine("Fel! Det går inte att betala med minus.");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Endast siffror, tack!");
                } 
            }

            // Avrunda
            attBetala = (uint)Math.Round(totalSumma);
            avrundningsTal = attBetala - totalSumma;

            // Kvitto
            Console.WriteLine("|KVITTO----------------------");
            Console.WriteLine("|Totalt: {0, 16} kr", totalSumma);
            Console.WriteLine("|Öresavrundning: {0, 8:f2} kr", avrundningsTal);
            Console.WriteLine("|Att betala: {0, 12} kr", attBetala);
            Console.WriteLine("|Kontant: {0, 15} kr", kontanter);
            Console.WriteLine("|Tillbaka: {0, 14} kr", (kontanter - attBetala));
            Console.WriteLine("-----------------------------");

            


        }
    }
}
