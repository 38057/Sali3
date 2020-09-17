using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Sali3
{
    class Rasvaprosentti
    {
        public string Sukupuoli { get; set; }
        public string Ika { get; set; }

        // Oletusmuodostin

        public Rasvaprosentti()
        {
            this.Sukupuoli = "Mies";
            this.Ika = "0";
        }

        // Metodi kaikilla parametreillä

        public Rasvaprosentti(string sukupuoli, string ika)
        {
            this.Sukupuoli = sukupuoli;
            this.Ika = ika;
        }

        public float RasvaAikuinen(float pituus, float paino)
        {
            float BMI = paino / (pituus * pituus);
            float sukupkerroin = 0;
            if (this.Sukupuoli == "mies")
            {
                sukupkerroin = 1;
            }
        
            float rasva = 1.2f * BMI + 0.23f * float.Parse(this.Ika) - 10.8f * sukupkerroin - 5.4f;
            return rasva;
           
        }

        // Staattinen lasku metodi, jolla rasvaprosentin voi laskea ilman oliota

        static public float laskeRasva(float paino, float pituus, float ika, string sukupuoli)
        {
            float BMI = paino / (pituus * pituus);
            float sukukerroin = 0;
            sukupuoli = sukupuoli.ToLower();
            if (sukupuoli == "mies")
            {
                sukukerroin = 1;
            }
            float rasva = 1.2f * BMI + 0.23f * ika - 10.8f * sukukerroin - 5.4f;
            return rasva;
        }
    }
}
