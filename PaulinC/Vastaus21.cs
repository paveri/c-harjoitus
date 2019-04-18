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
            byte n1, n2;
            int vastaus;
            n1 = 3;
            n2 = 2;
            vastaus = n1 + n2;
            Console.WriteLine(vastaus);
            Console.WriteLine("Laskutoimitus: " + n1 + " + " + n2 + " = " + vastaus);           
            Console.WriteLine("Paina jotain");
            Console.ReadKey();
         }
    }
}
