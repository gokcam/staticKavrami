using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı: {0}",Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Gökhan","Çam");
            Console.WriteLine("Çalışan sayısı: {0}",Calisan.CalisanSayisi);


            Console.WriteLine("Toplama sonucu: {0}",Islemler.Topla(200,35));
            Console.WriteLine("Çıkarma sonucu: {0}",Islemler.Cikar(200,35));


        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;  }

        private string isim;
        private string soyisim;

        public Calisan(string isim, string soyisim)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            calisanSayisi++;
        }

        static Calisan()
        {
            calisanSayisi = 0;

        }



    }

    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1+sayi2;
        }

        public static long Cikar(int sayi1,int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}