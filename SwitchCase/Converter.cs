using System;

namespace kvaernsletten
{
    class Converter
    {
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Velg hva du vil konvertere:");
                Console.WriteLine("1. Valuta");
                Console.WriteLine("2. Temperatur");
                Console.WriteLine("3. Vekt");
                Console.WriteLine("4. Avslutt");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 4)
                {
                    Console.WriteLine("Programmet avsluttes.");
                    break;
                }

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = ConvertCurrency();
                        break;
                    case 2:
                        result = ConvertTemperature();
                        break;
                    case 3:
                        result = ConvertWeight();
                        break;
                    default:
                        Console.WriteLine("Ugyldig valg. Prøv igjen.");
                        continue;
                }

                Console.WriteLine($"Resultatet av konverteringen er: {result}");
            }
        }

         double ConvertCurrency()
        {
            Console.WriteLine("Skriv inn beløpet i NOK:");
            double nok = double.Parse(Console.ReadLine());

            Console.WriteLine("Vil du konvertere til EUR eller USD? (Skriv 'EUR' eller 'USD'):");
            string currencyTo = Console.ReadLine();

            double rate = currencyTo == "EUR" ? 0.11 : 0.12;

            return nok * rate;
        }

         double ConvertTemperature()
        {
            Console.WriteLine("Skriv inn temperaturen i Celsius:");
            double celsius = double.Parse(Console.ReadLine());

            Console.WriteLine("Vil du konvertere til Fahrenheit eller Kelvin? (Skriv 'F' eller 'K'):");
            string tempTo = Console.ReadLine();

            double result = 0;

            if (tempTo == "F")
            {
                result = celsius * 9 / 5 + 32;
            }
            else if (tempTo == "K")
            {
                result = celsius + 273.15;
            }

            return result;
        }

         double ConvertWeight()
        {
            Console.WriteLine("Skriv inn vekten i kilogram:");
            double kg = double.Parse(Console.ReadLine());

            Console.WriteLine("Vil du konvertere til pounds eller ounces? (Skriv 'p' eller 'o'):");
            string weightTo = Console.ReadLine();

            double result = 0;

            if (weightTo == "p")
            {
                result = kg * 2.20462;
            }
            else if (weightTo == "o")
            {
                result = kg * 35.27396;
            }

            return result;
        }
    }
}
