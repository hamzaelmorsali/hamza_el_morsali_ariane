using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ariane
{
    class Program
    {
        static void Main(string[] args)
        {
            double tronc = 0, tempo=0;
            double spazio = 0;
            double velocità = 0;
            //errore di tempo fatto dalla base militare
            tronc = 0.000000095;
            tempo = tronc *100*60*60*10;
            Console.WriteLine($"il tempo totale è {tempo}");
            //spazio totale errato
            Console.WriteLine("inserisci la velocità");
            velocità = Convert.ToDouble(Console.ReadLine());
            spazio = velocità * tempo;
            Console.WriteLine($"lo spazio totale è {spazio}");
            Console.ReadLine();

        }
    }
}
