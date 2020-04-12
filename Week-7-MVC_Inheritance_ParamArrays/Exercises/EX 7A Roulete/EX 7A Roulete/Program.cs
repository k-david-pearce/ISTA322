﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_7A_Roulete
{
    class Program
    {
        static void Main(string[] args)
        {
            //// IN CLASS 
           
            //int[] greenNull = new int[2] { 0, 00 };
            //int[] black = new int[18] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
            //int[] red = new int[18] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
            //Random rand = new Random();
            //int num = 0;

            //Console.WriteLine("how many times do you want to spin?");
            //int cNumbers = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < cNumbers; i++)
            //{
            //    int color = rand.Next(1, 4);
            //    switch (color)
            //    {
            //        case 1:
            //            Console.WriteLine("green 00");
            //            break;
            //        case 2:
            //            Console.WriteLine("green 0");
            //            break;
            //        case 3:
            //            num = red[rand.Next(0, red.Length)];
            //            Console.WriteLine($"Red {num}");
            //            break;
            //        case 4:
            //            num = black[rand.Next(0, black.Length)];
            //            Console.WriteLine($"Black {num}");
            //            break;
            //    }
            //    //if (red.Contains(rand.Next(i)));
            //}

            // ACCORDING TO INSTRUCTIONS
            Random rand = new Random();
            int number = 0;
            string color;
            string[] numbers = new string[38];
            numbers[0] = "00";
            for (int i = 0; i < 37; i++)
            {
                numbers[i + 1] = (i).ToString();
            }

            try
            {
                Console.WriteLine("Welcome to Roulette! Enter 1 to spin the wheel.");
                int numSpins = Convert.ToInt32(Console.ReadLine());
                while (numSpins != 1)
                {
                    Console.WriteLine("Welcome to Roulette! Enter 1 to spin the wheel.");
                    numSpins = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < numSpins; i++)
                {
                    number = rand.Next(0, numbers.Length);

                    if (number == 0 || number == 1)
                    {
                        color = "green";
                    }
                    else
                    {
                        if (number % 2 == 0)
                        {
                            color = "red";
                        }
                        else
                            color = "black";
                    }
                    Console.WriteLine($"\nThe winning bin is {color} {numbers[number]}!");
                    Console.WriteLine("\nThe following bets are winners:\n");

                    // 1. Number of the bin
                    if (number == 0 || number == 1)
                    {
                        color = "green";
                        Console.WriteLine("The number is 0 or 00. Dealer Wins :(");
                    }
                    else
                    {
                        Console.WriteLine($"If you bet on {color} {numbers[number]} you win!");
                    }

                    // 2-3. Evens/Odds and Red/Black:
                    if (number == 0 || number == 1)
                    {
                        Console.WriteLine("Try Again");
                    }
                    else
                    {
                        if (number % 2 == 0)
                        {
                            Console.WriteLine("Odds and red win");
                        }
                        else
                        {
                            Console.WriteLine("Evens and black win");
                        }
                    }

                    // 4. Lows/Highs
                    if (number > 1 && number <= 19)
                    {
                        Console.WriteLine("The number is between 1-18. Lows win.");
                    }
                    else if (number > 1 && number > 19)
                    {
                        Console.WriteLine("The number is between 19-38. Highs win.");
                    }

                    // 5. Dozens
                    if (number > 1 && number <= 13)
                    {
                        Console.WriteLine("Dozens 1-12 wins.");
                    }
                    else if (number > 1 && number >= 26)
                    {
                        Console.WriteLine("Dozens 25-36 wins.");
                    }
                    else if (number > 1 && number > 13 && number < 26)
                        Console.WriteLine("Dozens 13-24 wins.");

                    // 6. Columns 
                    for (int colNum = 2; colNum <= 35; colNum += 3)
                    {
                        if (number == colNum)
                            Console.WriteLine("First column wins");
                    }
                    for (int colNum = 3; colNum <= 36; colNum += 3)
                    {
                        if (number == colNum)
                            Console.WriteLine("Second column wins");
                    }
                    for (int colNum = 4; colNum <= 37; colNum += 3)
                    {
                        if (number == colNum)
                            Console.WriteLine("Third column wins");
                    }
                }
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
            }
        }
    }
}

