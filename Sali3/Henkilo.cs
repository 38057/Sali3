using System;
using System.Collections.Generic;
using System.Text;

namespace Sali3
{
    class Henkilo
    {
        // Määritellään kaikkien henkilöiden yhteiset ominaisuudet(kentät)
        // Jäsen luokka oerii nämä ominaisuudet
        protected string etunimi;
        protected string sukunimi;
        protected string katuosoite;
        protected string postinumero;
        protected string postitoimipaikka;

        // Olionmuodostimet (konstruktorit)

        // Oletusmuodostin
        public Henkilo()
        {
            this.etunimi = "etunimi";
            this.sukunimi = "sukunimi";
            this.katuosoite = "N/A";
            this.postinumero = "N/A";
            this.postitoimipaikka = "N/A";
        }

        public Henkilo(string etu, string suku, string katu, string pnro, string paikka)
        {
            this.etunimi = etu;
            this.sukunimi = suku;
            this.katuosoite = katu;
            this.postinumero = pnro;
            this.postitoimipaikka = paikka;
        }
        // Metodeja testaukseen
        public void naytaHenkilo()
        {
            Console.WriteLine("Etunimi on " + this.etunimi);
            Console.WriteLine("Sukunimi on " + this.sukunimi);
            Console.WriteLine("Katuosoite on " + this.katuosoite);
            Console.WriteLine("Postinumero on " + this.postinumero);
            Console.WriteLine("Postitoimipaikka on " + this.postitoimipaikka);
        }
    }
    class Jasen : Henkilo
    {
        // Jäsenolioiden erityisominaisuudet, joita ei ole Henkilo-luokassa
        protected string jasenid;
        protected string sukupuoli;
        protected string syntymaaika;

        public string Syntymaaika
        {
            get { return syntymaaika; }
        }

        // Muodstin kaikilla parametreillä

        public Jasen(string etu, string suku, string katu, string pnro, string paikka, string id, string spuoli, string syntya)
        {
            this.etunimi = etu;
            this.sukunimi = suku;
            this.katuosoite = katu;
            this.postinumero = pnro;
            this.postitoimipaikka = paikka;
            this.jasenid = id;
            this.sukupuoli = spuoli;
            this.syntymaaika = syntya;
        }

        public string Sukupuoli
        {
            get { return sukupuoli; }
        }

        public void naytaJasen()
        {
            Console.WriteLine("Etunimi on " + this.etunimi);
            Console.WriteLine("Sukunimi on " + this.sukunimi);
            Console.WriteLine("Katuosoite on " + this.katuosoite);
            Console.WriteLine("Postinumero on " + this.postinumero);
            Console.WriteLine("Postitoimipaikka on " + this.postitoimipaikka);
            Console.WriteLine("Jäsenid on " + this.jasenid);
            Console.WriteLine("Sukupuoli on " + this.sukupuoli);
            Console.WriteLine("Syntymäaika on " + this.syntymaaika);
        }
    }
}
