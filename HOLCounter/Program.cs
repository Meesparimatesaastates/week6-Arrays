using System;

namespace HOLCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o', ja 'l' tähte on lauses "Hello World!"

            string name = ("Hello World!").ToLower();
            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'h')
                { hCounter++; }
                if (name[i] == 'o')
                { oCounter++; }
                if (name[i] == 'l')
                { lCounter++; }
            }
            Console.WriteLine($"Hello World on {hCounter} 'h' tähte, {oCounter} '0' tähte ja {lCounter} 'l' tähte ");
        }
    }
}
