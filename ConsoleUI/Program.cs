﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
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
                string name = GetUserInput("Please enter a name");
                raffleNumber = GenerateRandomeNumber(min, max);
                Console.WriteLine("Do you want to add another name?");
                string otherName1 = Console.ReadLine();
                otherName = otherName1.ToLower();
                AddGuestsInRaffle(raffleNumber, GuestName );
            }
            while (otherName == "yes");
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

        }
        static void GetRaffleNumber()
        {
            int randomNumber;
            do
            {
                randomNumber = GenerateRandomeNumber(min, max);
            }
            while (guests.ContainsKey(randomNumber));

            Console.WriteLine();



        }



        static void Main(string[] args)
        {

            GetUserInfo();


        }

        //Start writing your code here
        private static Dictionary<int, string> guests = new Dictionary<int, string> { };
        private static int min = 1000;
        private static int max = 9999;
        private static int raffleNumber;
        private static Random _rdm = new Random();
        private static string GuestName;





        //static void MultiLineAnimation() // Credit: https://www.michalbialecki.com/2018/05/25/how-to-make-you-console-app-look-cool/
        //{
        //    var counter = 0;
        //    for (int i = 0; i < 30; i++)
        //    {
        //        Console.Clear();

        //        switch (counter % 4)
        //        {
        //            case 0:
        //                {
        //                    Console.WriteLine("         ╔════╤╤╤╤════╗");
        //                    Console.WriteLine("         ║    │││ \   ║");
        //                    Console.WriteLine("         ║    │││  O  ║");
        //                    Console.WriteLine("         ║    OOO     ║");
        //                    break;
        //                };
        //            case 1:
        //                {
        //                    Console.WriteLine("         ╔════╤╤╤╤════╗");
        //                    Console.WriteLine("         ║    ││││    ║");
        //                    Console.WriteLine("         ║    ││││    ║");
        //                    Console.WriteLine("         ║    OOOO    ║");
        //                    break;
        //                };
        //            case 2:
        //                {
        //                    Console.WriteLine("         ╔════╤╤╤╤════╗");
        //                    Console.WriteLine("         ║   / │││    ║");
        //                    Console.WriteLine("         ║  O  │││    ║");
        //                    Console.WriteLine("         ║     OOO    ║");
        //                    break;
        //                };
        //            case 3:
        //                {
        //                    Console.WriteLine("         ╔════╤╤╤╤════╗");
        //                    Console.WriteLine("         ║    ││││    ║");
        //                    Console.WriteLine("         ║    ││││    ║");
        //                    Console.WriteLine("         ║    OOOO    ║");
        //                    break;
        //                };
        //        }

        //        counter++;
        //        Thread.Sleep(200);
        //    }
        //}
    }
}
