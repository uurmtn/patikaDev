using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                System.Console.WriteLine(outSayi);
            }
            else
            {
                System.Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplamSonucu);
            System.Console.WriteLine(toplamSonucu);

            //Metot aşırı yükleme -- Overloading

            int ifade = 999;
            instance.EkranaYaz(Convert.ToString(ifade));
            instance.EkranaYaz(ifade);
            instance.EkranaYaz("Uğur", " Metin");

            //Metot imzası
            //metotAdi + parametre sayisi + parametre
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int topla)
        {
            topla = a + b;
        }
        public void EkranaYaz(string veri)
        {
            System.Console.WriteLine(veri);
        }
        public void EkranaYaz(int veri)
        {
            System.Console.WriteLine(veri);
        }
        public void EkranaYaz(string veri1, string veri2)
        {
            System.Console.WriteLine(veri1 + veri2);
        }
    }

}