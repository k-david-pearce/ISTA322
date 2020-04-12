using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8G
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Declare an array named myArray of type int and length 64 
            int[] myArray = new int[64];

            // 6. Use for loop to iterate thru myArray and
            //    assign each element to its index
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
            }

            // 7. Use foreach loop to iterate thru myArray and
            //    print each array element to the console

            foreach (int num in myArray)
            {
                Console.WriteLine(num);
            }
        }
    }
}
