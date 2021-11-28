using System;

namespace StringReplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //progamm asendab kõik 'o' tähed lauses "Hello World" tärniga (*)
            string helloW = "Hello World !";

            helloW = helloW.Replace('o', '*');
            helloW = helloW.Replace('!', '2');
            Console.WriteLine(helloW);

        }
    }
}
