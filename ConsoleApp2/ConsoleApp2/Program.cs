using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Lütfen Yaşınınızı Giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            int sonuc = 20 - yas;
            if (sonuc == 0)
            {
                Console.WriteLine("Askerlik Zamanı");
            } 
            else if (sonuc > 20)
            {
                Console.WriteLine("Askerlik Şubesine başvurun");
            }
            else if (sonuc < 20)
            {
                Console.WriteLine("Askere Gitmenize {0} yıl var.", sonuc);
            }

            Console.ReadKey();

        }
    }
}
