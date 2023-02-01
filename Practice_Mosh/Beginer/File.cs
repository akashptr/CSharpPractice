using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Mosh.Beginer
{
    internal class File
    {
        /*
         * Write a program that reads a text file and displays the number of words.
         */
        public static int Exersize1(string path)
        {
            if (!System.IO.File.Exists(path))
            {
                Console.WriteLine("Invalid path");
                return -1;
            }
            string allText = System.IO.File.ReadAllText(path);

            var words = allText.Replace('\n', ' ').Split(" ");
            return words.Length;
        }
        /*
         * Write a program that reads a text file and displays the longest word in the file.
         */
        public static string Exersize2(string path)
        {
            if (!System.IO.File.Exists(path))
            {
                Console.WriteLine("Invalid path");
                return "";
            }
            string allText = System.IO.File.ReadAllText(path);

            var words = allText.Replace('\n', ' ').Split(" ");
            string maxStr = "";
            foreach(var word in words)
            {
                if(word.Length > maxStr.Length)
                    maxStr = word;
            }
            return maxStr;
        }
    }
}
