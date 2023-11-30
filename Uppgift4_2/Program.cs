using System;

namespace Uppgift4__2
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue; // Initialisera det största talet med det minsta värdet för ett heltal

            bool continueInput = true;

            while (continueInput)
            {
                Console.WriteLine("Skriv in ett heltal tack :)");
                int userInput = int.Parse(Console.ReadLine());

                // Kolla om det inmatade talet är större än det hittills största talet
                if (userInput > maxNumber)
                {
                    maxNumber = userInput;
                }

                Console.WriteLine("Vill du skriva in ett till heltal? (ja/nej)");
                string answer = Console.ReadLine();

                if (answer.ToLower() != "ja")
                {
                    continueInput = false;
                }
            }

            Console.WriteLine($"Det största talet du skrev in var:99 {maxNumber}");
        }
    }
}
