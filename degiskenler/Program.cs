using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte b = 5;         //1 byte yer kaplar
            sbyte sb = 5;       //1 byte yer kaplar

            short s = 5;        //2 byte yer kaplar
            ushort us = 5;      //2 byte yer kaplar

            Int16 i16 = 2;      //2 byte yer kaplar
            int i = 2;          //4 byte yer kaplar
            Int32 i32 = 2;      //4 byte yer kaplar
            Int64 i64 = 2;      //8 byte yer kaplar

            uint ui = 2;        //4 byte yer kaplar
            long L = 2;         //8 byte yer kaplar
            ulong uL = 2;       //8 byte yer kaplar

            float f = 5;        //4 byte yer kaplar
            double d = 5;       //8 byte yer kaplar
            decimal dec = 5;    //16 byte yer kaplar

            char ch = '2';      //2 byte yer kaplar
            string str = "uğur";//sınırsız

            bool bT = true;
            bool bF = false;
            DateTime tarih = DateTime.Now;
            System.Console.WriteLine(tarih);

            object obj = 'x';
            object obj1 = 5;        //obje ile türlü veri tipinde değer verilerbilir

            // string ifadeler
            string str1 = string.Empty;
            str1 = "Uğur Metin";
            string ad = "Uğur ";
            string soyad = "Metin";
            string tamIsim = ad + " " + soyad;

            //integer tanımlama şekilleri
            int integer1 = 4;
            int integer2 = 7;
            int integer3 = integer1 * integer2;

            //boolean ifadeler
            bool bool1 = 10 < 2;

            //Değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            //Datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

        }
    }
}