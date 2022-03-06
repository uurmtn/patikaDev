using System;

namespace whileForeach
{
    class program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan alınan sayının ortalaması
            Console.WriteLine("Sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 0;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);


            // 'a' dan 'z'ye kadar tüm harfleri yaz
            char karakter= 'a';
            while (karakter <= 'z')
            {
                Console.WriteLine(karakter);
                karakter++;
            }

            //foreach
            string[]arabalar={"BMV","Honda","Ford","Audi"};

            foreach (var araba in arabalar)
            {
             Console.WriteLine(araba);   
            }
        }
    }
}
