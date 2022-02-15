using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //Constructor --> class'ı new'lediğinizde burası çalışır, ctor tab tab ile açılır, class ismi ile aynı olur.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //geçici dizi. Diziler new'lendiğinde daha önceden girilen değerler sıfırlanıyor bunun sebebi dizinin referansı new'lendiğinde değişiyor. tempArray-geçiciDizi ile items'ın referansına eşitledik.
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length-1] = item;
            
        }
    }
}
