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

            // Testataan muodostin kaikilla parametreillä

            Henkilo henkilo1 = new Henkilo("Akseli", "Lehto", "Aarnontie 1", "23100", "Mynämäki");

            // Testataan Jasen-olion muodostimen toiminta

            Jasen jasen = new Jasen("Akseli", "Lehto", "Aarnontie 1", "23100", "Mynämäki", "69", "1");

            // Testataan Trainer-olion muodostimen toiminta

            Henkilosto.Trainer trainer = new Henkilosto.Trainer("Captain", "Lou", "Brooklyn", "6969", "USA", "MARIO", "123 456 789", "mario.mario@mail.com");

            // Testataan painoindeksi muodostimen toiminta

            Painoindeksi painoindeksi = new Painoindeksi("10.9.2020", "1,93", "106,5");

            // Testataan rasvaprosentin laskemista

            Rasvaprosentti rasvaprosentti = new Rasvaprosentti();

            // Katsotaan olioden ominaisuuksia

            Console.WriteLine("Testi oletusmuodostimelle");
            henkilo.naytaHenkilo();
            Console.WriteLine("Testi muodostimelle kaikilla parametreillä");
            henkilo1.naytaHenkilo();
            Console.WriteLine("Testi jäsen muodostimelle");
            jasen.naytaJasen();
            Console.WriteLine("Testi trainerin muodostimelle");
            trainer.naytaTrainer();
            Console.WriteLine("Testi painoindeksin muodostimelle");
            painoindeksi.naytaBMI();
            Console.WriteLine("Painoindeksi on " + painoindeksi.BMI());

            // Testataan rasvaprosenttilaskenta

            rasvaprosentti.Ika = "27";
            rasvaprosentti.Sukupuoli = "Mies";
            Console.WriteLine("Ikäsi on " + rasvaprosentti.Ika);
            Console.WriteLine("Sukupuolesi on " + rasvaprosentti.Sukupuoli);
            Console.WriteLine("Rasvaprosenttisi on " + rasvaprosentti.RasvaAikuinen(1.93f, 106f));

            // Testataan naisen rasvaprosenttilaskenta

            Rasvaprosentti nainen = new Rasvaprosentti("Nainen", "25");
            
            Console.WriteLine("Naisen rasvaprosentti on " + nainen.RasvaAikuinen(1.71f, 59f));

            // Testataan staattista rasvaprosentti metodia

            Console.WriteLine("Rasvaprosentti on " + Rasvaprosentti.laskeRasva(106.7f, 1.93f, 27, "Mies"));

        }
    }
}
