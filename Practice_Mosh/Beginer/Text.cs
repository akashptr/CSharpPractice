using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Practice_Mosh.Beginer
{
    internal class Text
    {
        /* Write a program and ask the user to enter a few numbers separated by a hyphen. 
         * Work out if the numbers are consecutive. 
         * For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
         * display a message: "Consecutive"; 
         * otherwise, display "Not Consecutive".
         */
        public static void Exersize1()
        {
            Console.WriteLine("Enter the numbers seperated by '-'");
            string[] input = Console.ReadLine().Split('-');
            var prevElement = Convert.ToInt32(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                var currentElement = Convert.ToInt32(input[i]);
                if (currentElement != prevElement + 1)
                {
                    Console.WriteLine("Not Consecutive");
                    return;
                }
                prevElement = currentElement;
            }
            Console.WriteLine("Consecutive");
        }

        /*
         * Write a program and ask the user to enter a few numbers separated by a hyphen. 
         * If the user simply presses Enter, without supplying an input, exit immediately; 
         * otherwise, check to see if there are duplicates. 
         * If so, display "Duplicate" on the console.
         */
        public static void Exersize2()
        {
            Console.WriteLine("Enter the numbers seperated by '-'");
            var inputString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputString))
                return;
            string[] input = inputString.Split('-');
            var uniqueNumbers = new List<int>();
            var containsDuplicates = false;
            foreach(var number in input)
            {
                var num = Convert.ToInt32(number);
                if(uniqueNumbers.Contains(num))
                {
                    containsDuplicates = true;
                    break;
                }
                uniqueNumbers.Add(num);
            }
            if(containsDuplicates)
                Console.WriteLine("Duplicate");
            else
                Console.WriteLine("No Duplicate");
        }

        /*
         * Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
         * A valid time should be between 00:00 and 23:59. 
         * If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
         * If the user doesn't provide any values, consider it as invalid time.
         */
        public static void Exersize3()
        {
            Console.WriteLine("Enter the time is 24-hours format");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid");
                return;
            }
            var hourMinute = input.Split(':');
            var hour = Convert.ToInt32(hourMinute[0]);
            var minute = Convert.ToInt32(hourMinute[1]);
            if (hour < 0 || hour > 23 || minute < 0 || minute > 59)
            {
                Console.WriteLine("Invalid");
                return;
            }
            Console.WriteLine("Ok");
        }

        /*
         * Write a program and ask the user to enter a few words separated by a space. 
         * Use the words to create a variable name with PascalCase. 
         * For example, if the user types: "number of students", display "NumberOfStudents". 
         * Make sure that the program is not dependent on the input. 
         * So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
         */
        public static void Exersize4()
        {
            Console.WriteLine("Enter few words");
            var inputString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputString))
                return;
            var input = inputString.Split(' ');
            StringBuilder result = new StringBuilder();
            foreach(var word in input)
                result.Append(char.ToUpper(word[0]) + word.ToLower().Substring(1));
            Console.WriteLine(result.ToString());
        }

        /*
         * Write a program and ask the user to enter an English word. 
         * Count the number of vowels (a, e, o, u, i) in the word. 
         * So, if the user enters "inadequate", the program should display 6 on the console.
         */
        public static void Exersize5()
        {
            Console.WriteLine("Enter a word");
            var inputString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputString))
                return;
            var count = 0;
            foreach(var ch in inputString)
            {
                switch(char.ToLower(ch))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        count++;
                        break;
                }
            }
            Console.WriteLine("Total number of vowels is: " + count);
        }
    }
}
