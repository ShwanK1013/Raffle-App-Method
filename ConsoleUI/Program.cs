using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Party!!");
            GetUserInfo();
            MultiLineAnimation();
            PrintGuestsName();
            PrintWinner();
            

            Console.WriteLine("type any key to exit");
            string cmdHolder = Console.ReadLine();


        }

        //Start writing your code here
        private static Dictionary<int, string> guests = new Dictionary<int, string> { };
        private static int min = 1000;
        private static int max = 9999;
        private static int raffleNumber;
        private static Random _rdm = new Random();
        private static int randomNumber;
        private static string GuestName;
        private static Random _raffleIndex = new Random();

        static string GetUserInput(string input)
        {
            
            Console.WriteLine(input);
            return GuestName = Console.ReadLine();
        }

        static void GetUserInfo()
        {
            
            string otherName;
            do
            {
                GetUserInput("Please enter a name");

                while (GuestName == "")
                { 
                    GetUserInput("Please enter a valid name");
                }

                raffleNumber = GenerateRandomeNumber(min, max);

                

                while (guests.ContainsKey(raffleNumber))
                {
                    raffleNumber = GenerateRandomeNumber(min, max); 
                }

                AddGuestsInRaffle(raffleNumber, GuestName);

                GetUserInput("Do you want to add another name?");

                //GetUserInput("Do you want to add another name?");

                //string otherName1 = Console.ReadLine();

                otherName = GuestName.ToLower();

               
            }
            while (otherName == "yes" );
        }

        static int GenerateRandomeNumber(int min, int max)
        {
            return _rdm.Next(min, max);
        }

        static void AddGuestsInRaffle(int raffleNumber, string GuestName)
        {
            guests.Add(raffleNumber, GuestName);
        }
        static void PrintGuestsName()
        {
            foreach (KeyValuePair<int, string> i in guests)
            {
                Console.WriteLine(i);
            }
        }
        static void GetRaffleNumber()
        {

            int index = _raffleIndex.Next(guests.Count);
            randomNumber = guests.Keys.ElementAt(index);


            //do
            //{
            //    randomNumber = GenerateRandomeNumber(min, max);
            //}
            //while (!guests.ContainsKey(randomNumber));


        }


        static void PrintWinner()
        {
            
            GetRaffleNumber();
            Console.WriteLine($"The Winner is: {guests[randomNumber]} with the #{randomNumber}");
        }





        static void MultiLineAnimation() // Credit: https://www.michalbialecki.com/2018/05/25/how-to-make-you-console-app-look-cool/
        {
            var counter = 0;
            for (int i = 0; i < 30; i++)
            {
                Console.Clear();

                switch (counter % 4)
                {
                    case 0:
                        {
                            Console.WriteLine("         ╔════????════╗");
                            Console.WriteLine("         ║    │││ \\   ║");
                            Console.WriteLine("         ║    │││  O  ║");
                            Console.WriteLine("         ║    OOO     ║");
                            break;
                        };
                    case 1:
                        {
                            Console.WriteLine("         ╔════????════╗");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    OOOO    ║");
                            break;
                        };
                    case 2:
                        {
                            Console.WriteLine("         ╔════????════╗");
                            Console.WriteLine("         ║   / │││    ║");
                            Console.WriteLine("         ║  O  │││    ║");
                            Console.WriteLine("         ║     OOO    ║");
                            break;
                        };
                    case 3:
                        {
                            Console.WriteLine("         ╔════????════╗");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    OOOO    ║");
                            break;
                        };
                }

                counter++;
                Thread.Sleep(75);
            }
        }
    }
}
