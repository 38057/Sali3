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
        }
        //Lasketaan painoindeksi
        public float BMI()
        {
            // Muutetaan olion string metodit float muotoon
            float paino = float.Parse(this.paino);
            float pituus = float.Parse(this.pituus);
            float bmi = paino / (pituus * pituus);
            return bmi;
        }
        //Testausmetodi
        public void naytaBMI()
        {
            Console.WriteLine("Punnituspäivä: " + this.paiva);
            Console.WriteLine("Paino: " + this.paino);
            Console.WriteLine("Pituus " + this.pituus);
     
        }

    }
}
