using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kvaernsletten
{
    internal class SwitchCase
    {
        public void Run()
        {
            Oppgave1();
            Oppgave2();
            //arrowKeyMovement();

        }


        public void Oppgave1()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 8);
            Console.WriteLine("Random number is " + randomNumber);

            switch (randomNumber) { 
            
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        } 
        public void Oppgave2() 
        {
            var number = Console.ReadLine();

            switch (number)
            {

                case "1":
                    Console.WriteLine("Monday");
                    break;
                case "2":
                    Console.WriteLine("Tuesday");
                    break;
                case "3":
                    Console.WriteLine("Wednesday");
                    break;
                case "4":
                    Console.WriteLine("Thursday");
                    break;
                case "5":
                    Console.WriteLine("Friday");
                    break;
                case "6":
                    Console.WriteLine("Saturday");
                    break;
                case "7":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Not a valid key");
                    Oppgave2();
                    break;
            }
        }

        public void arrowKeyMovement()
        {
            Console.WriteLine("Press any arrow key to begin!");
            var keyPressed = Console.ReadKey().Key;
            switch (keyPressed) {

                case ConsoleKey.UpArrow:
                    Console.WriteLine($"You pressed " + keyPressed + "and walk north.");
                    Run();
                    break;

                case ConsoleKey.LeftArrow:
                    Console.WriteLine($"You pressed " + keyPressed + "and walk west.");
                    Run();
                    break;

                case ConsoleKey.DownArrow:
                    Console.WriteLine($"You pressed " + keyPressed + "and walk south.");
                    Run();
                    break;

                case ConsoleKey.RightArrow:
                    Console.WriteLine($"You pressed " + keyPressed + "and walk east.");
                    Run();
                    break;
                default:
                    Console.WriteLine(" is not a valid key");
                    Run();
                    break;
            }


        }
    }
}
