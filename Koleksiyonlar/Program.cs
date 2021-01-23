using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Miraç","Taha","Hasan" };
            //Console.WriteLine(isimler[1]);

            List<string> isimler2 = new List<string> {"Engin","Taha" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            isimler2.Add("Miraç");
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
