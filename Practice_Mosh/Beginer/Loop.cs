using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Mosh.Beginer
{
    class Loop
    {
        /*
         * Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
         * Display the count on the console.
         */
        public static int Exersize1(int uLimit)
        {
            int count = 0;
            for(int i=1; i<=uLimit; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            return count;
        }

        /*
         * Write a program and continuously ask the user to enter a number or "ok" to exit. 
         * Calculate the sum of all the previously entered numbers and display it on the console.
         */
        public static void Exersize2()
        {
            int sum = 0;
            while(true)
            {
                string input = Console.ReadLine();
                if(string.IsNullOrEmpty(input))
                    continue;
                if (input == "ok")
                    break;
                sum += int.Parse(input);
            }
            Console.WriteLine("Sum = " + sum);
        }

        /*
         * Write a program and ask the user to enter a number. 
         * Compute the factorial of the number and print it on the console. 
         * For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
         */
        public static void Exersize3()
        {
            var fact = 1;
            var input = int.Parse(Console.ReadLine());
            for(var i=2; i<=input; i++)
                fact *= i;
            Console.WriteLine(fact);
        }

        /*
         * Write a program that picks a random number between 1 and 10. 
         * Give the user 4 chances to guess the number. 
         * If the user guesses the number, display “You won"; otherwise, display “You lost". 
         * (To make sure the program is behaving correctly, you can display the secret number on the console first.)
         */
        public static void Exersize4(int low, int high)
        {
            var randomObj = new Random();
            while(true)
            {
                Console.WriteLine("Enter \"ok\" to exit");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    continue;
                if (input == "ok")
                    break;
                var rand = randomObj.Next(low, high+1);
                var userGuess = int.Parse(input);
                if (rand == userGuess)
                    Console.WriteLine(rand + " You Won");
                else
                    Console.WriteLine(rand + " You Lost");
            }
        }

        /*
         * Write a program and ask the user to enter a series of numbers separated by comma. 
         * Find the maximum of the numbers and display it on the console. 
         * For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
         */
        public static void Exersize5()
        {
            var input = Console.ReadLine().Split(',');
            var arr = new int[input.Length];
            var min = int.MaxValue;
            for(int i=0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(input[i]);
                if(arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine(min);
        }
    }
}
