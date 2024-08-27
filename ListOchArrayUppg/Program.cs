using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOchArrayUppg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testIntArray = { 1, 42, 3, 6 }; // kan ändras, ska ändå bli rätt svar
            int[] testIntArray2 = { 1, 26, 5, 7, 77 };

            // Sum
            Console.WriteLine("Demonstration av Sum:");
            Console.WriteLine("Summan av testdata är: " + Summan(testIntArray));

            // Max
            Console.WriteLine();
            Console.WriteLine("Demonstration av Max:");
            Console.WriteLine("Största talet av testdata är: " + Maximum(testIntArray2).ToString()); // TODO

        }

        public static int Summan(int[] numbers)
        {
            int sum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            
            return sum;
        }

        public static int Maximum(int[] numbers2)
        {
            int maybeMax = 0;
            int highestNum = 0;
            
            for (int i = 1; i < numbers2.Length; i++)
            {
                if (numbers2[i] > maybeMax)
                {
                    maybeMax = numbers2[i];
                }
            }

            highestNum = maybeMax;

            return highestNum;
        }
    }
}
