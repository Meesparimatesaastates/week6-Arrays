using System;

namespace ACharacterCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonna nime
            //programm kuvab, mitu "a" tähte on  kasutaja ees- ja perekonnanimes kokku
            Console.WriteLine("sisesta oma eesnimi: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("sisesta oma perekonna nimi");
            string lastName = Console.ReadLine();
            string fullName = $"{firstname}{lastName}".ToLower();

            int aCounter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a')
                { aCounter++; }

            }
            if (aCounter != 1)
            {
                Console.WriteLine($"sinu täisnimes {aCounter} 'a' tähte");
            }
            else
            {
                Console.WriteLine($"sinu eesnimes {aCounter} 'a' täht");
            }

        }
    }
}
