using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Kimlik
    {
        string ad;
        string soyad;
        string memleket;
        int yas;
        char cinsiyet;

        public string AD
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value.ToLower();
            }
        }
        public string SOYAD
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value.ToLower();
            }
        }
        public string MEMLEKET
        {
            get
            {
                return memleket;
            }
            set
            {
                memleket = value;
            }
        }
        public int YAS
        {
            get
            {
                return yas;
            }
            set
            {
                yas = Math.Abs(value);
            }
        }
        public char CINSIYET
        {
            get
            {
                return cinsiyet;
            }
            set
            {
                cinsiyet = value;
            }
        }
        public Kimlik()
        {
            ad = "";
            soyad="";
            yas = 18;
            cinsiyet ='k';
            memleket = "Ankara";
        }
    }
}
