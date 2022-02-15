using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.MusteriId = 1;
            musteri1.Adi = "Semih";
            musteri1.SoyAdi = "GOKKAN";
            musteri1.TcNo = "123456789";


            Musteri musteri2 = new Musteri();

            musteri2.MusteriId = 2;
            musteri2.Adi = "Büşra";
            musteri2.SoyAdi = "GOKKAN";
            musteri2.TcNo = "987654321";

            Musteri musteri3 = new Musteri();

            musteri3.MusteriId = 3;
            musteri3.Adi = "İsmail";
            musteri3.SoyAdi = "ÇALIŞIR";
            musteri3.TcNo = "852741369";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);

            Console.WriteLine("----------------------");

            musteriManager.Sil(musteri2);

            Console.WriteLine("---------------------");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteri = new MusteriManager();
            musteriManager.Listele(musteriler);
           
        }
    }
}
