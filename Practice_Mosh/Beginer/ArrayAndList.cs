using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Mosh.Beginer
{
    class ArrayAndList
    {
        /*
         * When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
         *
         * If no one likes your post, it doesn't display anything.
         * If only one person likes your post, it displays: [Friend's Name] likes your post.
         * If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
         * If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
         * Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
         * Depending on the number of names provided, display a message based on the above pattern.
         */
        public static void Exersize1()
        {
            List<string> names = new List<string>();
            while(true)
            {
                var name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                    break;
                names.Add(name);
            }
            switch(names.Count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine(names[0] + " likes your post");
                    break;
                case 2:
                    Console.WriteLine(names[0] + " and " + names[1] + " likes your post");
                    break;
                default:
                    Console.WriteLine(names[0] + ", " + names[1] + " and " + (names.Count - 2) + " others like your post");
                    break;
            }
        }

        /*
         * Write a program and ask the user to enter their name. 
         * Use an array to reverse the name and then store the result in a new string. 
         * Display the reversed name on the console.
         */
        public static void Exersize2()
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            var length = name.Length;
            char[] rName = new char[length];
            for(int i=length - 1; i>=0; i--)
            {
                rName[length - 1 - i] = name[i];
            }
            var result = string.Join("", rName);
            Console.WriteLine(result);
        }

        /*
         * Write a program and ask the user to enter 5 numbers. 
         * If a number has been previously entered, display an error message and ask the user to re-try. 
         * Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
         */
        public static void Exersize3()
        {
            List<int> numbers = new();
            while(numbers.Count < 5)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                if(numbers.Contains(input))
                {
                    Console.WriteLine("You have previously entered " + input);
                    continue;
                }
                numbers.Add(input);
            }
            numbers.Sort();
            Console.WriteLine("The list:");
            foreach(var number in numbers)
                Console.WriteLine(number);
        }

        /*
         * Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
         * The list of numbers may include duplicates. 
         * Display the unique numbers that the user has entered.
         */
        public static List<int> Exersize4(int[] numbers)
        {
            var uniqueNumbers = new List<int>();
            foreach(var number in numbers)
                if(!uniqueNumbers.Contains(number))
                    uniqueNumbers.Add(number);
            return uniqueNumbers;
        }

        /*
         * Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
         * If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
         * otherwise, display the 3 smallest numbers in the list.
         */
        public static int[] Exersize5(int[] numbers, int k)
        {
            Array.Sort(numbers);
            var result = new int[k];
            for(int i=0; i<k; i++)
                result[i] = numbers[i];
            return result;
        }
    }
}
