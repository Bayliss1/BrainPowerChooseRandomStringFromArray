using System;

namespace BrainPowerChooseRandomStringFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string[] myArray;
            myArray = new string[6];
            myArray[3] = "Test 3";
            myArray[5] = "Test 5";

            Console.WriteLine(myArray[(random.Next(6))]);
        }
    }
}
