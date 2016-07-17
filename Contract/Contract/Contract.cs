using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    [Serializable]
    public class Contract
    {
        int cod;
        string denumire;
        double valoare;

        public Contract(int cod, string denumire, double valoare) {
            this.cod = cod;
            this.denumire = denumire;
            this.valoare = valoare;
        }
        
        public int getCod() {
            return this.cod;
        }
        public string getDenumire()
        {
            return this.denumire;
        }
        public double getValoare()
        {
            return this.valoare;
        }

        public void setCod(int cod) {
            this.cod = cod;
        }
        public void setDenumire(string denumire)
        {
            this.denumire = denumire;
        }
        public void setValoare(double valoare)
        {
            this.valoare = valoare;
        }

        public static double operator +(double d, Contract c)
        {
            double rezultat = d + c.getValoare();
            return rezultat;
        }
    }
}
