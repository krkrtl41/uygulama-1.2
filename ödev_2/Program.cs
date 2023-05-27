using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int toplam = 0;
            for (int a = 1; a <= sayi; a++)
            {
                toplam += a;
            }

            Console.WriteLine("Sonuç : " + toplam);
            Console.ReadKey();
        }
    }
}
