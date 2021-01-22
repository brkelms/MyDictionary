using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> kullanicilar = new MyDictionary<int, string>();
            kullanicilar.Add(123, "Burak");
            kullanicilar.Add(50923, "Selim");
            kullanicilar.Add(13, "Elif");
            kullanicilar.Count();
        }
    }
}
