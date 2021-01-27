using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                Ad = "Seckin",
                Sehir = "Antalya",
                Soyad = "Bakir"
            };
            Customer customer1 = new Customer(2, "Yagmur", "Ulag", "Antalya");

            Console.WriteLine(customer1.Sehir);

        }


        class Customer
        {

            public int Id { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Sehir { get; set; }

            public Customer()
            {

            }
            public Customer(int id, string ad, string soyad, string sehir)
            {
                Id = id;
                Ad = ad;
                Soyad = soyad;
                Sehir = sehir;


            }
        }
    }
}
