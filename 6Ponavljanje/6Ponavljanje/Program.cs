using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Ponavljanje
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nizBrojeva = new int[5];
            int zbroj;
            double prosjek;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Upisite " + (i + 1) + ". broj: ");
                nizBrojeva[i] = Convert.ToInt32(Console.ReadLine());

            }
            KlasaC newObjekt = new KlasaC();
            zbroj = newObjekt.Zbroj(nizBrojeva);
            prosjek = newObjekt.Prosjek(nizBrojeva);
            Console.WriteLine("Zbroj iznosi: " + zbroj + "\n" + "Prosjek iznosi: " + prosjek);


            Console.ReadKey();
        }
    }
}
