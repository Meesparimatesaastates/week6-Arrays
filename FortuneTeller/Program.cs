using System;

namespace FortuneTeller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis juhtub kasutajaga homme (kasutame Random klassi)
            string[] prediction = { "win a million", "fall in love", "buy youtube premium", "join the darkside for cookies" };
            //Console.WriteLine("enter a number from 0 to 4");
            Random rnd = new Random();
            int number = rnd.Next(0, prediction.Length);
            Console.WriteLine($"tomorrow you will {prediction[number]}.");
        }
    }
}
