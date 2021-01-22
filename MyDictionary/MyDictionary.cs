using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1, T2>
    {
        T1[] anahtarlar;
        T2[] bilgiler;
        public MyDictionary()
        {
            anahtarlar = new T1[0];
            bilgiler = new T2[0];
        }
        public void Add(T1 anahtar, T2 bilgi)
        {
            T1[] yedekAnahtarlar = anahtarlar;
            T2[] yedekBilgiler = bilgiler;
            anahtarlar = new T1[anahtarlar.Length + 1];
            bilgiler = new T2[bilgiler.Length + 1];
            for (int i = 0; i < yedekBilgiler.Length; i++)
            {
                bilgiler[i] = yedekBilgiler[i];
                anahtarlar[i] = yedekAnahtarlar[i];

            }
            anahtarlar[anahtarlar.Length - 1] = anahtar;
            bilgiler[bilgiler.Length - 1] = bilgi;
            Console.WriteLine(bilgi + " bilgisi şu anahtarla eşleştirildi :" + anahtar);
        }
        public void Count()
        {
            int toplam = bilgiler.Length;
            Console.WriteLine("Dizideki eleman sayısı :" + toplam);
        }
    }
}
