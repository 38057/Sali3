using System;
using System.Collections.Generic;
using System.Text;

namespace Sali3
{
    // Lasketaan painoindeksi
    class Painoindeksi
    {
        // Painoindeksin kenttä arvot
        protected string paiva;
        protected string pituus;
        protected string paino;

        // Muutetaan kentän arvot publiciksi
        public string Paino
        {
            get { return paino; }
        }

        public string Pituus
        {
            get { return pituus; }
        }

        // Muodostin kaikilla parametreilla
        public Painoindeksi(string paiva, string pituus, string paino)
        {
            this.paiva = paiva;
            this.pituus = pituus;
            this.paino = paino;
            
        }
        
        //Testausmetodi
        public void naytaPunnitus()
        {
            Console.WriteLine("Punnituspäivä: " + this.paiva);
            Console.WriteLine("Paino: " + this.paino);
            Console.WriteLine("Pituus " + this.pituus);
     
        }

    }
}
