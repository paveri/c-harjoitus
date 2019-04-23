using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace harjoitus31
{
    class Program
    {
        static void Main(string[] args)
        {
            string teksti;
            Console.Write("Kirjoita tekstiä:");
            teksti=Console.ReadLine();
			Console.WriteLine(teksti);
            Console.ReadKey();
        }
    }
}

namespace harjoitus32
{
    class Program
    {
        static void Main(string[] args)
        {
            string teksti, sana;
            sana = "hevonen";
            Console.Write("Arvaa joku eläin: ");
            teksti = Console.ReadLine();
            if (teksti == sana)
            {
                Console.WriteLine("Arvasit oikein");
            }
            else
            {
                Console.WriteLine("Arvasit väärin, oikea eläin oli " + sana);
            }
            Console.WriteLine("Paina jotain");
            Console.ReadKey();
          
        }
    }
}

namespace harjoitus33
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2;
            luku2 = 100;
            Console.Write("Arvaa joku luku: ");
            luku1 = int.Parse(Console.ReadLine());
            if (luku1 == luku2)
            {
                Console.WriteLine("Arvasit oikein");
            }
            else
            {
                Console.WriteLine("Arvasit väärin, oikea luku oli " + luku2);
            }
            Console.WriteLine("Paina jotain");
            Console.ReadKey();

        }
    }
}

namespace harjoitus34
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2;
            luku2 = 100;
            Console.Write("Arvaa joku luku: ");
            luku1 = int.Parse(Console.ReadLine());
            if (luku1 == luku2)
            {
                Console.WriteLine("Arvasit oikein");
            }
            else if (luku1 > luku2)
            {
                Console.WriteLine("Arvasit väärin, luku on liian suuri");
            }
            else
            {
                Console.WriteLine("Arvasit väärin, luku on liian pieni");
            }
            Console.WriteLine("Paina jotain");
            Console.ReadKey();
        }
    }
}
namespace harjoitus35
{
    class Program
    {
        static void Main(string[] args)
        {
            double  luku1, luku2, tulos;
            Console.Write("Anna luku1: ");
            luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna luku2: ");
            luku2 = int.Parse(Console.ReadLine());
            tulos = (double)luku1 + luku2;
            Console.WriteLine(luku1 + " + " + luku2 + " = " + tulos);
            Console.WriteLine("Paina jotain");
            Console.ReadKey();
        }
    }
}

namespace harjoitus36
{
    class Program
    {
        static void Main(string[] args)
        {
            double sade, ala , pii;
            Console.Write("Anna ympyrän säde: ");
            pii = Math.PI;
            sade = int.Parse(Console.ReadLine());
            ala = (double)pii * sade * sade;
            Console.WriteLine("Ympyrän ala on " + ala);
            Console.WriteLine("Paina jotain");
            Console.ReadKey();
        }
    }
}

namespace harjoitus37
{
    class Program
    {
        static void Main(string[] args)
        {
            double pituus;
            double paino;
            double tuplapituus;
            double painokerroin;

            Console.Write("Anna pituutesi: ");
            pituus = double.Parse(Console.ReadLine());
            Console.Write("Anna painosi: ");
            paino = double.Parse(Console.ReadLine());

            tuplapituus = (double)pituus * pituus / 10000;
            painokerroin = (double)paino / tuplapituus;
            Console.WriteLine("Painokertoimesi on " + String.Format("{0:0.00}", painokerroin) + " ja LAIHDUTA");
            Console.WriteLine("Paina jotain");
            Console.ReadKey();
        }
    }
}

namespace harjoitus38
{
    class Program
    {
        static void Main(string[] args)
        {
            double luku1, luku2, tulos;
            string merkki;

            Console.Write("Anna luku1: ");
            luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna luku2: ");
            luku2 = int.Parse(Console.ReadLine());
            
            Console.Write("Anna laskutapa : ");
            merkki = Console.ReadLine();

            string lause = luku1 + merkki + luku2 + " = ";

            if (merkki == "*")
            {
                tulos = (double)luku1 * luku2;
                Console.WriteLine(lause + tulos);
            }
            else if (merkki == "+")
            {
                tulos = (double)luku1 + luku2;
                Console.WriteLine(lause + tulos);
            }
            else if (merkki == "-")
            {
                tulos = (double)luku1 - luku2;
                Console.WriteLine(lause + tulos);
            }
            else if (merkki == "/")
            {
                tulos = (double)luku1 / luku2;
                Console.WriteLine(lause + tulos);
            }
            else 
            {
                Console.WriteLine("nyt yrität jotain kvanttifysiikkaa");
            }

            Console.WriteLine("Paina jotain");
            Console.ReadKey();
        }
    }
}
*/
namespace harjoitus311
{
    class Program
    {
        static void Main(string[] args)
        {
            int lampotila;
            string merkki;

            Console.Write("Anna veden lämpötila: ");
            lampotila = int.Parse(Console.ReadLine());

            if (lampotila > 100)
            {
                Console.WriteLine("höyryä");
            }
            else if (lampotila > 0)
            {
                Console.WriteLine("vettä");
            }
            else if (lampotila > -273)
            {
                Console.WriteLine("jäätä");
                        }
            else
            {
                Console.WriteLine("män alle absoluuttisen nollapisteen");
            }

            Console.WriteLine("Paina jotain");
            Console.ReadKey();
        }
    }
}


