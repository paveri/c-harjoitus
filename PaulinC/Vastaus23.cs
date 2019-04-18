using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulinC
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            double vastaus;
            n1 = 25;
            n2 = 5;
            n3 = 100;
            vastaus = (double)n1 * n2;
            Console.WriteLine("välivastaus " + n1 + "*" + n2 + "=" + vastaus);
            Console.ReadKey();
            vastaus = (double)n1 * n2 / n3;
            Console.WriteLine(vastaus);
            Console.WriteLine("lopputulos" + n1 + "*" + n2 + "/" + n3 + "=" vastaus);
            Console.WriteLine("Paina jotain");
            Console.ReadKey();
         }
    }
}
