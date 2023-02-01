using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Mosh.Advance
{
    internal class NullableDemo
    {
        public static void Main(string[] args)
        {
            // Declaring Nullable type
            //Nullable<DateTime> birthday = null;
            DateTime? birthday = null;
            // Default value of the struct
            DateTime date1 = birthday.GetValueOrDefault();
            Console.WriteLine(date1);
            // Custom defautl value
            DateTime date2 = birthday ?? DateTime.Today;
            Console.WriteLine(date2);
        }
    }
}
