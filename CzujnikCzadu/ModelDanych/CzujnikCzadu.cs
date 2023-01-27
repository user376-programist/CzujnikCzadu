using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CzujnikCzadu.ModelDanych
{
    internal class Czujnik_Czadu
    {
        private int CzestotliwoscPomiaru;
        private int GranicznyPoziomCzadu;
        private DateTime DataZamontowaniaBaterii;

        public Czujnik_Czadu( int CzestotliwoscPomiaru, DateTime DataZamontowaniaBaterii)
        {
            this.CzestotliwoscPomiaru = 30;
            this.GranicznyPoziomCzadu = 35;
            this.DataZamontowaniaBaterii = DataZamontowaniaBaterii;
        }

        public int PoziomBaterii()
        {
            int bateria = Convert.ToInt32(DateTime.Now) / Convert.ToInt32(DataZamontowaniaBaterii) * 100;
            return bateria;
        }

        public void WymienBaterie()
        {
            this.DataZamontowaniaBaterii = DateTime.Now;
        }

        public void ZmienCzestotliwosc()
        {
            Console.WriteLine("Ustaw częstotliwość pomiaru");
            int p = int.Parse(Console.ReadLine());
            CzestotliwoscPomiaru = p;
        }

        public string PoziomCzadu(int czad) //XD
        {
            czad = int.Parse(Console.ReadLine());
            if(czad == GranicznyPoziomCzadu)
            {
                return "OSTRZEŻENIE! Poziom czadu osiągnął 35ppm.";
            }
            else if(czad > GranicznyPoziomCzadu)
            {
                return "NIEBEZPIECZEŃSTWO! Poziom czadu przekroczył poziom 35ppm";
            }
        }


    }
}
