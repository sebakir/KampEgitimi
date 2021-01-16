using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // NewMethod();
            // NewMethod1();

        }

        private static void NewMethod1()
        {
            string[] kurslar = new string[] {"Yazılım geliştirici Yetiştirme Kampı" ,
                "Programalamaya baslangic için teml kurs",
                "Java" };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }

        public static void NewMethod()
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrencisayisi = 32000;
            double faizOrani = 1.45;
            bool girisYapdiMi = true;

            if (girisYapdiMi == true)
            {
                Console.WriteLine("Giriş yap");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu ");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
