using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime = "15 Nisan";
            Console.WriteLine(kelime);
            int sayyi = 1994;
            Console.WriteLine(sayyi);
            Console.WriteLine("Merhaba");
            Console.Write("Dünya \n");

            Mesaj msj = new Mesaj();
            msj.metin();

            Kisiler ks = new Kisiler();
            //ks.kisilistesi(" - Durmuş YAŞAR");
            //ks.kisilistesi(" - Yusuf YAŞAR");
            string ads;
            Console.Write("\nİsim Giriniz : ");
            ads = Console.ReadLine();
            ks.kisilistesi(ads);

            Islem isl = new Islem();
            isl.topla(15, 45);
            isl.kare(45);

            Ogrenci ogr = new Ogrenci();
            Ogrenci ogr2 = new Ogrenci("DurmusYASAR");
            string blg;
            Console.Write("Bilgi giriniz : ");
            blg = Console.ReadLine();
            Ogrenci ogr3 = new Ogrenci("Durum : " + blg);

            Kimlik kml = new Kimlik();
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CINSIYET);
            Kimlik km2 = new Kimlik();
            km2.AD = "Durmuş";
            km2.SOYAD = "YAŞAR";
            km2.MEMLEKET = "Trabzon";
            km2.YAS = 25;
            km2.CINSIYET = 'e';
            Console.WriteLine(km2.AD);
            Console.WriteLine(km2.SOYAD);
            Console.WriteLine(km2.MEMLEKET);
            Console.WriteLine(km2.YAS);
            Console.WriteLine(km2.CINSIYET);

            Console.Read();
        }
    }
}
