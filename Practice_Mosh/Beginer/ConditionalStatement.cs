using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Mosh.Beginer
{
    class ConditionalStatement
    {
        /*
         *  Write a program and ask the user to enter a number. 
         *  The number should be between 1 to 10. 
         *  If the user enters a valid number, display "Valid" on the console. 
         *  Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
         */
        public static void Exersize1(int n)
        {
            if (n > 0 && n < 11)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invlid");
        }

        /*
         * Write a program which takes two numbers from the console and displays the maximum of the two.
         */
        public static int Exersize2(int a, int b)
        {
            return (a < b) ? b : a;
        }

        /*
         * Write a program and ask the user to enter the width and height of an image. 
         * Then tell if the image is landscape or portrait.
         */
        public static void Exersize3(int height, int width)
        {
            if(height > width)
                Console.WriteLine("Portrait");
            else
                Console.WriteLine("Landscape");
        }

        /*
         * Your job is to write a program for a speed camera. 
         * For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. 
         * Write a program that asks the user to enter the speed limit. 
         * Once set, the program asks for the speed of a car. 
         * If the user enters a value less than the speed limit, program should display Ok on the console. 
         * If the value is above the speed limit, the program should calculate the number of demerit points. 
         * For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
         * If the number of demerit points is above 12, the program should display License Suspended.
         */
        public static void Exersize4(int speedLimit, int carSpeed)
        {
            int speedPerPoint = 5;
            if (carSpeed < speedLimit + speedPerPoint)
                Console.WriteLine("Your speed: " + carSpeed + " OK");
            else
            {
                int demeritPoints = (carSpeed - speedLimit) / speedPerPoint;
                if(demeritPoints > 12)
                    Console.WriteLine("Your speed: " + carSpeed + " demerit points: " + demeritPoints + " License Cancelled");
                else
                    Console.WriteLine("Your speed: " + carSpeed + " demerit points: " + demeritPoints);
            }
        }
    }
}
