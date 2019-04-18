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
            /*         
            char harjoitus24;
            string tek1 , tek2, kokoteksti;
            tek1 = "O";
            tek2 = "hjelmointi";
            kokoteksti = tek1 + tek2;
            Console.WriteLine(kokoteksti);           
            Console.WriteLine("Paina jotain");
            Console.ReadKey();

            char harjoitus25;
            int ika;
            Console.Write("Anna ikäsi: ");
            ika = Convert.ToInt32(Console.ReadLine());
            if (ika < 25)
            {
                Console.WriteLine("Olet " + ika + " vuotias ja ihan lapsi vielä");
            }
            else
            {
                Console.WriteLine("Olet " + ika + " vuotias ja kohta eläkkeellä");
            }
            Console.WriteLine("Paina jotain");
            Console.ReadKey();
            
            char harjoitus26;
            double tuumamitta;
            double sentit;
            double tuumasentti;

            Console.Write("Anna tuumat: ");
            tuumasentti = 2.54;
            tuumamitta = Convert.ToInt32(Console.ReadLine());
            sentit = (double)tuumamitta*tuumasentti;
            Console.WriteLine(tuumamitta + " tuumaa on " + sentit + " senttimetriä");
            Console.WriteLine("Paina jotain");
            Console.ReadKey();

            char harjoitus27;
            int luku1, luku2;
            int tulos;
          
            Console.Write("Anna luku1: ");
            luku1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna luku2: ");
            luku2 = Convert.ToInt32(Console.ReadLine());

            tulos = luku1 * luku2;
            Console.WriteLine(luku1 + " * " + luku2 +  " = " + tulos);
            Console.WriteLine("Paina jotain");
            Console.ReadKey();
            
            char harjoitus28;
            double kilohinta;
            double paljofyrkkaa;
            double namia;

            Console.Write("Anna kilohinta: ");
            kilohinta = Convert.ToDouble(Console.ReadLine());
            Console.Write("Anna rahamäärä: ");
            paljofyrkkaa = Convert.ToDouble(Console.ReadLine());

            namia = (double)paljofyrkkaa / kilohinta;
            Console.WriteLine("Namia saat " + String.Format("{0:0.00}", namia) + " kiloa");
            Console.WriteLine("Paina jotain");
            Console.ReadKey();

            char harjoitus29;
            double bruttopalkka;
            double veropros;
            double nettopalkka;
            double vero;

            Console.Write("Anna bruttopalkka: ");
            bruttopalkka = Convert.ToDouble(Console.ReadLine());
            Console.Write("Anna veropros%: ");
            veropros = Convert.ToDouble(Console.ReadLine());

            vero = (double)bruttopalkka * veropros / 100;
            nettopalkka = (double)bruttopalkka - vero;
            Console.WriteLine("Rahaa käteen tulloopi " + String.Format("{0:0.00}", nettopalkka) + " euroa");
            Console.WriteLine("Paina jotain");
            Console.ReadKey();

            char harjoitus210;
            */

            double pituus;
            double paino;
            double tuplapituus;
            double painokerroin;

            Console.Write("Anna pituutesi: ");
            pituus = Convert.ToDouble(Console.ReadLine());
            Console.Write("Anna painosi: ");
            paino = Convert.ToDouble(Console.ReadLine());

            tuplapituus = (double)pituus * pituus / 10000;
            painokerroin = (double)paino / tuplapituus;
            Console.WriteLine("Painokertoimesi on " + String.Format("{0:0.00}", painokerroin) + " ja LAIHDUTA");
            Console.WriteLine("Paina jotain");
            Console.ReadKey();
                                          
        }
    }
}
