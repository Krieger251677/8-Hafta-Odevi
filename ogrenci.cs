using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ogrenci
    {
        public int no { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public int dog_yıl { get; set; }
        public string bolum { get; set; }

        public void ogrenciBilgileri()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Öğrenci Bilgileri");
            Console.WriteLine("Numarası:   " + no);
            Console.WriteLine("Adı:        " + ad);
            Console.WriteLine("Soyadı:     " + soyad);
            Console.WriteLine("Doğum Yılı: " + dog_yıl);
            Console.WriteLine("Bölüm:      " + bolum);
            Console.WriteLine("***********************************");

        }


        public int vize { get; set; }
        public int final { get; set; }

        public double ortalama()
        {
            double a = (vize * 0.4) + (final * 0.6);
            return a;
        }

        public void karar()
        {

            if (ortalama() < 50)
            {
                Console.WriteLine("Kaldınız.");
            }
            else
            {
                Console.WriteLine("Geçtiniz.");
            }

        }

    }
}
