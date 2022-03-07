using System;

namespace arraysTwo
{
    class program
    {
        static void Main(string[] args)
        {
            //Sort sıralama işlemi
            int[] sayiDizisi = { 8, 23, 12, 47, 52, 5, 1, 21 };

            Console.WriteLine("Sırasız Dizi");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            System.Console.WriteLine("Sıralı Dizi");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }


            //Clear Dizi içerisinde verilen veri kadar verinin yerine o ile doldurur.

            System.Console.WriteLine("Array Clear");
            //sayiDizisi elemanlarını kullanarak 2. indexten itibaren 2 tane elemanı 0'lar.

            Array.Clear(sayiDizisi, 2, 2);

            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }

            //Reverse verilen diziyi sondan başa doğru sıralar
            System.Console.WriteLine("Array Reverse");

            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }

            //IndexOf Verilen dizinin verilen elemanının indexini getirir.
            System.Console.WriteLine("Array IndexOf");

            System.Console.WriteLine(Array.IndexOf(sayiDizisi, 47));


            //Resize Dizileri yeniden boyutlandırmak için kullanılır.
            System.Console.WriteLine("Array Resaize");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }
        }
    }
}