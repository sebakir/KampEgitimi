using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Seckin";
            musteri1.soyAd = "Bakır";
            musteri1.musteriNo = 123;



            MusteriManager manager = new MusteriManager();
            string yazi = "\n1.Ekle \n2.Guncelle \n3.Sil\n4.Listele\nCikis icin 0 a basin";
            Console.WriteLine("İslem seciniz ..." + yazi);
            var islem = Convert.ToInt16(Console.ReadLine());

            while (true)
            {
                if (islem.Equals(0))
                {
                    Console.WriteLine("Cikis yapiliyor... ");
                    break;
                }
                else if (islem.Equals(1))
                {
                    manager.Add(musteri1);
                    break;
                }
                else if (islem.Equals(2))
                {
                    manager.Update(musteri1);
                    break;
                }
                else if (islem.Equals(3))
                {
                    manager.Delete(musteri1);
                    break;
                }
                else if (islem.Equals(4))
                {
                    manager.Listing(musteri1);
                    break;
                }
                else
                {
                    break;
                }
            }
        }
    }
}

