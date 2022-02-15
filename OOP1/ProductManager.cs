using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)  // void ile int(değişkenlerin) farkı, void emir kipi gibi kullanılır git yap ve bitir örn: güncelle, ekle, sil. int return edileceklerde kullanılır. Örn toplama sonucu 9 ve devamında çarpma yapmak istiyoruz.
        {
            Console.WriteLine(sayi1+sayi2);
        }
    }
}
