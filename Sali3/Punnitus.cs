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

        // Muodostin kaikilla parametreilla
        public Painoindeksi(string paiva, string pituus, string paino)
        {
            this.paiva = paiva;
            this.pituus = pituus;
            this.paino = paino;
            if (pituus == "0" || paino == "0")
            {
                Console.WriteLine("Paino tai pituus tiedoissa ei saa olla nollaa!");
            }
            
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
