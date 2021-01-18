using System;
using System.Linq;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Adi = "Elma";
            product.Fiyati = 15;
            product.Aciklama = "Amasya Elmasi";

            Product product1 = new Product();
            product1.Adi = "Karpuz";
            product1.Fiyati = 80;
            product1.Aciklama = "Diyarbekir karpuzu";
            product1.stokAdedi = 5;

            Product[] productArray = new Product[]
            {
                product,
                product1
            };

            foreach (var i in productArray)
            {
                Console.WriteLine(i.Adi + " " + i.Fiyati + " " + i.Aciklama + " " + i.stokAdedi);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("--------------Methodlar------------- ");
            SepetManager sepet = new SepetManager();
            sepet.Add(product);
            sepet.Add(product1);


            //Add(1, 2, 3, 4, 5);

        }


        static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
