using System;

namespace arrays
{
    class program
    {
        static void Main(string[] args)
        {
            //Dizi tamınlamaları
            string[] colors = new string[5];

            string[] animals = { "Kedi", "Köpek", "Kuş", "Aslan" };

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim
            colors[0] = "Kırmızı";
            dizi[3] = 47;

            Console.WriteLine(animals[3]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(colors[0]);

            //Döngüler ile Dizi kullanımı
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayısı giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());

                int toplam = 0;
                foreach (var sayi in sayiDizisi)
                {
                    toplam += sayi;
                }
                Console.WriteLine("Ortalama: " + toplam / diziUzunlugu);
            }
        }
    }
}