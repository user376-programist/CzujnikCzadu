using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CzujnikCzadu.ModelDanych
{
    internal class BateriaCzujnika
    {
        private string NazwaProducenta;
        private DateTime DataZamontowaniaBaterii;
        private int CzasDzialania;

        public BateriaCzujnika(string NazwaProducenta, int CzasDzialania)
        {
            this.NazwaProducenta = NazwaProducenta;
            this.CzasDzialania = CzasDzialania;
        }

        public void datazamontowaniabaterii()
        {
            DataZamontowaniaBaterii = DateTime.Now;
        }

        public string DaneBaterii()
        {
            return NazwaProducenta + "\n" + DataZamontowaniaBaterii + "\n" + CzasDzialania + "\n" + $"Poziom baterii: {Convert.ToInt32(DateTime.Now) / Convert.ToInt32(DataZamontowaniaBaterii) * 100}%";
        }
    }
}
