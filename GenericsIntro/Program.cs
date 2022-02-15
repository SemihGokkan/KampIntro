using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>(); //Generic yapılara örnek, liste oluşturma..
            isimler.Add("Engin");

            Console.WriteLine("Hello World!");
        }
    }
}
