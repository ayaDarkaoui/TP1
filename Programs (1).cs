using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Client cl1 = new Client("darkaoui", "aya", "boulvard quods");
            Client cl2 = new Client("wisal", "chtmi", "les orangers");
        
            Comptes A = new Comptes(new MAD(2800), cl1, new MAD(3500));
            Comptes B = new Comptes(new MAD(8900) , cl2, new MAD(1200));

            A.Consulter();
            B.Consulter();

            A.Verser(B, new MAD(1500));
            Console.WriteLine("\n         Apres les virement:\n");
           
            A.Consulter();
            B.Consulter();

            Console.ReadKey();

        }
    }
}
