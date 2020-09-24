using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Sali3
{
    class Rasvaprosentti
    {
        // Staattinen metodi iän laskemiseksi
        static public int Ika(string syntymapaiva)
        {
            CultureInfo cultureInfo = new CultureInfo("fi-FI");
            DateTime vuosinolla = new DateTime(1, 1, 1);
            DateTime syntyaika = DateTime.Parse(syntymapaiva, cultureInfo);
            DateTime tanaan = DateTime.Now;
            TimeSpan ikaero = tanaan - syntyaika;
            int ika = (vuosinolla + ikaero).Year - 1;
            return ika;
        }

        // Staattinen metodi painoindeksin laskemiseksi
        static public float BMI(string pituus,string paino)
        {
          
            float painokg = float.Parse(paino);
            float pituusm = float.Parse(pituus);
            float bmi = painokg / (pituusm * pituusm);
            return bmi;
        }

        // Staattinen lasku metodi, jolla rasvaprosentin voi laskea ilman oliota

        static public float laskeRasva(float bmi, int ika, string sukupuoli)
        {
            float sukukerroin = 0;
            sukupuoli = sukupuoli.ToLower();
            if (sukupuoli == "mies")
            {
                sukukerroin = 1;
            }
            if (ika < 16)
            {
                float rasva2 = 1.51f * bmi - 0.7f * ika - 3.6f * sukukerroin + 1.4f;
                return rasva2;
            }
            float rasva = 1.2f * bmi + 0.23f * ika - 10.8f * sukukerroin - 5.4f;
            return rasva;
            

        }
    }
}
