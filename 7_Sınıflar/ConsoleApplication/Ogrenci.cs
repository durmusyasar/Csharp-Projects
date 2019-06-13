using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Ogrenci
    {
        // Yapıcı (Constructor)
        public Ogrenci()
        {
            Console.WriteLine("Ad : Durmuş");
            Console.WriteLine("Soyad : YAŞAR");
            Console.WriteLine("Meslek : Öğrenci");
        }
        public Ogrenci(string bilgi)
        {
            Console.WriteLine(bilgi);
        }
    }
}
