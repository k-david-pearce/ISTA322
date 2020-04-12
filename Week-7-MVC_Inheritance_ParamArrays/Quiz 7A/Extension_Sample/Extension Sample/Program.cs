using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Sample
{
    static class NewMethodClass
    {
        public static void M4(this ExtensionSample kyle)
        {
            Console.WriteLine("Method Name: M4");
        }
        public static void M5(this ExtensionSample kyle, string str)
        {
            Console.WriteLine(str);
        }

        public class cExtension
        {
            static void Main(string[] args)
            {
                ExtensionSample kyle = new ExtensionSample();
                kyle.M1();
                kyle.M2();
                kyle.M3();
                kyle.M4();
                kyle.M5("This is method 5");
            }
        } 
    }
}

