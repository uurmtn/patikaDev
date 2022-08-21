using System;

namespace genericKoleksiyonlar
{
    class Program
    {
        public static void Main(string[] args)
        {
            //List<T> class
            // System.Collections.GEneric
            // T -> objeck türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(47);
            sayiListesi.Add(21);
            sayiListesi.Add(34);
            sayiListesi.Add(35);
            sayiListesi.Add(74);
            sayiListesi.Add(5);


            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");
            renkListesi.Add("Siyah");
            renkListesi.Add("Mavi");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.Remove(52);
            renkListesi.Remove("Siyah");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(3);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Liste içi arama
            if (sayiListesi.Contains(47))
            {
                Console.WriteLine("47 liste içerisinde bulundu");
            }
            else
            {
                Console.WriteLine("47 liste içerisinde YOK...");
            }

            //Eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("Yeşil"));

            //Diziyi list' e çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanList = new List<string>(hayvanlar);


            //Listeyi temzileme
            hayvanList.Clear();

            //Liste içerisinde nesne tutmak
            List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Uğur";
            kullanıcı1.Soyisim = "METİN";
            kullanıcı1.Yas = 30;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Araf";
            kullanıcı2.Soyisim = "METİN";
            kullanıcı2.Yas = 7;

            kullaniciListesi.Add(kullanıcı1);
            kullaniciListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniList = new List<Kullanıcılar>();
            yeniList.Add(new Kullanıcılar()
            {
                Isim = "Defne",
                Soyisim = "Sude",
                Yas = 5

            });

            foreach (var kullanıcı in yeniList)
            {
                Console.WriteLine("Kullanıcı adı: "+ kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı: "+ kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı yaş: "+ kullanıcı.Yas);
            }

        }
    }

    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}