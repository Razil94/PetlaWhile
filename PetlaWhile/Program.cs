using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> values = new List<int>();

        while (true)
        {
            Console.Write("Podaj liczbę (0-10, wpisz 5 aby zakończyć): ");
            if (!int.TryParse(Console.ReadLine(), out int userInput) || userInput < 0 || userInput > 10)
            {
                Console.WriteLine("Wprowadź liczbę z zakresu 0-10.");
                continue;
            }

            if (userInput == 5)
                break;

            values.Add(userInput);
        }

        if (values.Count > 0)
        {
            int squaredSum = values.Sum(x => x * x);
            int minimumValue = values.Min();

            Console.WriteLine($"Suma kwadratów wprowadzonych liczb: {squaredSum}");
            Console.WriteLine($"Najmniejsza wprowadzona liczba: {minimumValue}");
        }
        else
        {
            Console.WriteLine("Nie wprowadzono żadnych liczb.");
        }
    }
}