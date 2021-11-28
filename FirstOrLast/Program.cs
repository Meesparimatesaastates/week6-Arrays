using System;

namespace FirstOrLast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees-ja perekonna nime
            //programm kontrollib andmete pikust
            //programm kuvab kumb nendest on pikema, kas ees-või perekonnanimi


            Console.WriteLine("sisesta eesnimi");

            string firstName = Console.ReadLine();
            Console.WriteLine("sisesta perekonnanimi");
            string lastName = Console.ReadLine();

            //int firstNameLenght = firstName.Length;

            if (firstName.Length < lastName.Length)
            { Console.WriteLine("Sinu perekonna nimi sisaldab rohkem sümboleid kui eesnimi, palju õnne"); }
            else if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Sinu eesnimi sisaldab rohkem sümboleid kui perekonna nimi, palju õnne!");
            }
            else
            { Console.WriteLine("Su ees- ja perekonna nimed sisaldavad samapalju sümboleid , palju õnne!"); }

        }
    }
}
