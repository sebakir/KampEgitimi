using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Seckin Bakir
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Ad = "Seckin";
            musteri1.Soyad = "Bakir";
            musteri1.TcNo = "123124123123";


            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12345677890";

            // Gercek musteri
            //SOLID


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);
            customerManager.Ekle(musteri3);
            customerManager.Ekle(musteri4);



        }
    }
}
