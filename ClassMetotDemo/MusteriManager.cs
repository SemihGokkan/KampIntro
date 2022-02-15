using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi");
            Console.WriteLine("Eklenen kişinin Adı, SoyAdı:" +musteri.Adi + " " + musteri.SoyAdi + " " + musteri.TcNo);
        }

        public void Listele(Musteri[] musteri)
        {
            Console.WriteLine("Banka Müşterilerimiz");
            foreach (var musteriler in musteri)
            {
                Console.WriteLine(musteriler.MusteriId + " " + musteriler.Adi + " " + musteriler.SoyAdi + " " + musteriler.TcNo);
            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi.");
            Console.WriteLine("Silinen kişinin bilgileri:" + " " + musteri.MusteriId + " " + musteri.Adi + " " + musteri.SoyAdi + " " + musteri.TcNo);
        }
    }
}
