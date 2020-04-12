using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_8A_Bisection_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 15, 3, 5, 2, 40 };

            Array.Sort(arr);

            Console.WriteLine("Choose a number: 15, 3, 5, 2, 40");
            int userInput = int.Parse(Console.ReadLine());

            int split = arr.Length / 2;

            Console.WriteLine($"The first number checked is at index {split}");

            while (arr[split] != userInput)
            {
                if (arr[split] > userInput)
                {
                    split = (arr.Length - split) / 2;
                    Console.WriteLine($"The next index checked is {split}");
                }
                else
                {
                    split = split / 2;
                    Console.WriteLine($"The next index checked is {split}");
                }
            }
            if (arr[split] == userInput)
            {
                Console.WriteLine($"User Input was at index {split} and the number is {arr[split]}");
            }
            

        }    
    }
}
