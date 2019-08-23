using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aufgabe3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double startKapital;
            double zinsSatz;
            double endkapital;
            int laufZeit = 3;
            double zinsesZins;

            Console.WriteLine("Wie hoch ist ihr Startkapital?");
            startKapital = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wie hoch ist ihr Zinssatz?");
            zinsSatz = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wie hoch ist ihre Laufzeit?");
            laufZeit = Convert.ToInt32(Console.ReadLine());

            zinsSatz = 1+ zinsSatz / 100;

            zinsesZins = Math.Pow(zinsSatz, laufZeit);
            Console.WriteLine(zinsesZins);

            endkapital = startKapital * zinsesZins;

            Console.WriteLine("Ihr Endkapital nach 3 Jahren ist: " + endkapital);
            Console.ReadKey();
        }    
       
    }
}
