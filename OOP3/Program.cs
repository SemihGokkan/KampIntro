using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IKrediManager yazsakta olur, interface'ler de, o interface implamente eden class'ın referans numarasını tutabiliyor.
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //IKrediManager
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //IKrediManager
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, konutKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
