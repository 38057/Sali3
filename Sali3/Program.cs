using System;

namespace Sali3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testataan Henkilo-olion luontia");

            /*----------------------------------------------------
             | TESTAUS ALKAA TÄSTÄ                               |
             |---------------------------------------------------*/

            // Testataan oletusmuodostin

            Henkilo henkilo = new Henkilo();

            //Testataan muodostin kaikilla parametreillä

            Henkilo henkilo1 = new Henkilo("Akseli", "Lehto", "Aarnontie 1", "23100", "Mynämäki");

            //Testataan Jasen-olion muodostimen toiminta

            Jasen jasen = new Jasen("Akseli", "Lehto", "Aarnontie 1", "23100", "Mynämäki", "69", "1");

            // Katsotaan olion ominaisuuksia
            Console.WriteLine("Testi oletusmuodostimelle");
            henkilo.naytaHenkilo();
            Console.WriteLine("Testi muodostimelle kaikilla parametreillä");
            henkilo1.naytaHenkilo();
            Console.WriteLine("Testin jäsen muodostimelle");
            jasen.naytaJasen();
        }
    }
}
