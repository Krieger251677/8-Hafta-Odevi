using System;

namespace ConsoleApp1
{
    class Program
    {

    /*    öğrenci sınıfı oluşturulacak, özellikler öğrenci No, ad, soyad, doğum yılı, bölüm 
     *    (teknik bilimlerden olması lazım),
          vize notu final notu ortalama ve karar(geçti kaldı) get set kullanılarak 
          sınıf ve nesne oluşturulacak, 
          nesnenin özellikleri ekrana yazdırıacak
    */

        static void Main(string[] args)
        {
            // Öğrenci bilgileri
            ogrenci ogrenci = new ogrenci
            {
                no = 221903061,
                ad = "Abdulkadir",
                soyad = "Yeşilkaya",
                dog_yıl = 2001,
                bolum = "Bilgisayar Programcılığı",

            };

            ogrenci.ogrenciBilgileri();

            ogrenci notlar = new ogrenci();

            Console.WriteLine("Vize Notunuzu Giriniz. ");

            notlar.vize = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Final Notunuzu Giriniz. ");
            notlar.final = Convert.ToInt32(Console.ReadLine());
            


            Console.WriteLine("Notların Ortalaması => " + notlar.ortalama());

            notlar.karar();

        }
    }
}
