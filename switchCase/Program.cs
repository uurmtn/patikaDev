using System;

namespace switchCase
{
    class Program
    {
        public static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            
            
            //Expression kontrol etmek istenen konuşul.
            switch (month)
            {
                case 1:
                    System.Console.WriteLine("Ocak Ayındasınız");
                    break;
                case 2:
                    System.Console.WriteLine("Şubat Ayındasınız");
                    break;
                case 3:
                    System.Console.WriteLine("Mart Ayındasınız");
                    break;
                case 4:
                    System.Console.WriteLine("Nisan Ayındasınız");
                    break;
                case 5:
                    System.Console.WriteLine("Mayıs Ayındasınız");
                    break;
                default:
                    System.Console.WriteLine("Yanlış veri girişi");
                    break;
            }

            switch (month)
            {
                case 1:
                case 2:
                case 3:
                    System.Console.WriteLine("Kış Mevsimindesiniz");
                    break;
                case 4:
                case 5:
                case 6:
                    System.Console.WriteLine("İlkbahar Mevsimindesiniz");
                    break;
                case 7:
                case 8:
                case 9:
                    System.Console.WriteLine("Yaz Mevsimindesiniz");
                    break;
                case 10:
                case 11:
                case 12:
                    System.Console.WriteLine("Sonbahar Mevsimindesiniz");
                    break;
                default:
                    System.Console.WriteLine("Yanlış veri girişi");
                    break;
            }
        }
    }
}