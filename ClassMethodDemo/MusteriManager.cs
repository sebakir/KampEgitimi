using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {

            Console.WriteLine(musteri.Ad + "  " + musteri.soyAd + " \nnumarası : " + musteri.musteriNo + " \neklendi...");
        }
        public void Update(Musteri musteri)
        {
            Console.WriteLine("Güncellenecek müşteri ismini giriniz ");
            var ad = Console.ReadLine();
            if (ad.Equals(musteri.Ad))
            {
                string islem = "1.Adı guncelle \n2.Soyad Guncelle \n3.MusteriNo guncelle";
                Console.WriteLine("Islem seciniz ... : \n" + islem);
                int secim = Convert.ToInt16(Console.ReadLine());

                if (secim.Equals(1))
                {
                    Console.WriteLine("Yeni Ad giriniz : ");
                    string newAd = Console.ReadLine();
                    musteri.Ad = newAd;
                    Console.WriteLine("Ad guncellendii...");
                    Console.WriteLine("Yeni ad : " + musteri.Ad);
                }
                else if (secim.Equals(2))
                {
                    Console.WriteLine("Yeni SoyAd giriniz : ");
                    string newSoyAd = Console.ReadLine();
                    musteri.soyAd = newSoyAd;
                    Console.WriteLine("SoyAd guncellendii...");
                    Console.WriteLine("Yeni soyad : " + musteri.soyAd);
                }
                else if (secim.Equals(3))
                {
                    Console.WriteLine("Yeni No giriniz : ");
                    int newNo = Convert.ToInt16(Console.ReadLine());
                    musteri.musteriNo = newNo;
                    Console.WriteLine("Numara guncellendii...");
                    Console.WriteLine("Yeni no : " + musteri.musteriNo);


                }

            }
        }

        public void Listing(Musteri musteri)
        {
            Console.WriteLine("Listelenecek müşteri ismini giriniz ");
            var ad = Console.ReadLine();
            Console.WriteLine(musteri.Ad + "  " + musteri.soyAd + " \nnumarası : " + musteri.musteriNo + " \neklendi...");

        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Silinecek müşteri ismini giriniz ");
            var ad = Console.ReadLine();
            Console.WriteLine("Kullancı Siliniyor....");
            Console.WriteLine(musteri.Ad + " silindi");
        }
    }
}
