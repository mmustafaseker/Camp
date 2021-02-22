using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Mylist<string> isimler = new Mylist<string>();
            isimler.Add("mustafa");

            Console.WriteLine(isimler.Length);

            isimler.Add("ali");

            Console.WriteLine(isimler.Length);

        }
    }
}
