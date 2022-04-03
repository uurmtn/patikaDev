using System;

namespace RecursiveOrExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Özyinelemeli fonksiyon
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;

            }
            Console.WriteLine(result);
            İslemler instance = new();
            System.Console.WriteLine(instance.Expo(3, 4));


            //Extension Metot statik olamalı
            string ifade = "Uğur Metin";
            bool sonuc = ifade.CheckSpaces();
            System.Console.WriteLine(sonuc);

            if (sonuc)
            {
                System.Console.WriteLine(ifade.RemoveWhiteSpaces());
            }

            System.Console.WriteLine(ifade.MakeUpperCase());
            System.Console.WriteLine(ifade.MakeLowerCase());


            int[] dizi = { 9, 3, 6, 2, 1, 5, 0, 47 };
            dizi.SortArray();
            dizi.EkranaYaz();

            int sayi=5;
            System.Console.WriteLine(sayi.IsEvenNumber());

            System.Console.WriteLine(ifade.GetFirstCharacter());

        }
    }


    public class İslemler
    {
        public int Expo(int sayi, int üs)
        {
            if (üs < 2)
            {
                return sayi;
            }
            return Expo(sayi, üs - 1) * sayi;
        }
    }

    public static class Extansion
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join(" -_- ", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYaz(this int[] param)
        {
            foreach (int item in param)
            {
                System.Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param %2==0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}