using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string soyAd { get; set; }
        public int musteriNo { get; set; }


        public void Add2(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad);
        }
    }
}
