using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager //interface kuralları içerir. Bu interface kullanan (implamente eden) sınıflar kuralları kendine göre kullanmak durumunda. Örn. Her kredinin farklı kodları var.
    {
        void Hesapla();
        void BiseyYap();

    }
}
