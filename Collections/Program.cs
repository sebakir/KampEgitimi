using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>
            {
                "Seçkin",
                "Yagmur"
            };

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
