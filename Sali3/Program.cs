using System;


namespace Sali3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*----------------------------------------------------
             | TESTAUS ALKAA TÄSTÄ                               |
             |---------------------------------------------------*/

            // Testataan Jasen-olion muodostimen toiminta

            Jasen jasen = new Jasen("Akseli", "Lehto", "Aarnontie 1", "23100", "Mynämäki", "69", "mies", "15.5.1993");

            // Testataan painoindeksi muodostimen toiminta

            Painoindeksi painoindeksi = new Painoindeksi("15.5.1993", "1,93", "106,7");

            // Katsotaan olioden ominaisuuksia

            Console.WriteLine("Testi jäsen muodostimelle");
            jasen.naytaJasen();
            Console.WriteLine("Testi painoindeksin muodostimelle");
            painoindeksi.naytaPunnitus();

            // Testi iän laskennan toimimisesta

            int vuotta = Rasvaprosentti.Ika("15.5.1993");
            Console.WriteLine("Mä oon " + vuotta + " vanha");

            // Testataan BMI laskenta

            float bmi = Rasvaprosentti.BMI("1,93", "106,7");
            Console.WriteLine("Painoindeksi on " + bmi);

            // Testataan rasvaprosentin laskeminen

            float rasvaprosentti = Rasvaprosentti.laskeRasva(bmi, vuotta, "mies");
            Console.WriteLine("Rasvaprosentti on " + rasvaprosentti);

            // Testataan iän laskenta jäsen oliosta

            Console.WriteLine("Ikä on " + Rasvaprosentti.Ika(jasen.Syntymaaika));

            int jasenika = Rasvaprosentti.Ika(jasen.Syntymaaika);
            float jasenbmi = Rasvaprosentti.BMI(painoindeksi.Pituus, painoindeksi.Paino);
            float jasenrasva = Rasvaprosentti.laskeRasva(bmi, jasenika, jasen.Sukupuoli);
            Console.WriteLine("Jäsenen ikä on " + jasenika + " BMI on " + jasenbmi + " rasvaprosentti on " + jasenrasva);
            if (painoindeksi.Pituus == "0" || painoindeksi.Paino == "0")
            {
                Console.WriteLine("Paino tai pituus tiedoissa ei saa olla nollaa!");
            }
            



        }
    }
}
