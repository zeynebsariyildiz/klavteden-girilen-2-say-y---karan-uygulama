using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klavteden_girilen_2_sayıyı_çıkaran_uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2,fark;
            Console.WriteLine("Lütfen Bir Sayı Giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen  Bir Sayı Daha Giriniz");
            sayi2 = Convert.ToInt32((Console.ReadLine()));
            fark = sayi1 - sayi2;
            //{ bu paranteze gerek yok
            Console.WriteLine("Girdiğiniz Sayıların Farkı = {0}", fark);
            //}bu paranteze gerek yok
            Console.ReadKey();
        }
    }
}
