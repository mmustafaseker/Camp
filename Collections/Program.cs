using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "mustafa","gizem","seda","züleyha" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            //// new dediğimiz anda yeni bir array bellekte  oluşur 00 tertemiz
            //isimler = new string[5];

            //isimler[4] = "ayşe";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            // ama listelerde işler değişiyor
            List<string> isimler2 = new List<string> { "mustafa", "gizem", "seda", "züleyha" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
        }
    }
}
