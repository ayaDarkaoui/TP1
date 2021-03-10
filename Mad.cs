using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN
{
    class MAD
    {
        private  double valeur;
        

        public MAD(double s)
        {
            this.valeur = s;
        }

        public void Print()
        {
            Console.WriteLine(this.valeur+" MAD");
        }

       
        public static bool operator >(MAD x, MAD y)
        {
            if (x.valeur > y.valeur) return true;

            return false;
        }

        public static bool operator <(MAD x, MAD y)
        {
            if (x.valeur < y.valeur) return true;

            return false;
        }
        public static MAD operator -(MAD x, MAD y)
        {
            return new MAD(x.valeur - y.valeur);
        }
        public static MAD operator +(MAD x, MAD y)
        {
            return  new MAD(x.valeur + y.valeur);
        }

    }
}
