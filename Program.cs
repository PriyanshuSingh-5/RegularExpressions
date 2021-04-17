using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user Registration");
            string pattern = "^[A-Z]{1}[a-z]{2,}$"; //Pattern for characters

            //Pattern for  last name

            string[] inputs1 = { "Aaa", "Aaaa", "aA11", "bAc", "1A1aab", "1aAb23a" };
            

            Program p = new Program();
            p.ValidateChracters(inputs1, pattern);
           

        }

        public void IterateLoop(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool result = regex.IsMatch(arr[i]);
                if (result)
                {
                    Console.WriteLine(arr[i] + "------>" + "Valid");
                }
                else
                {
                    Console.WriteLine(arr[i] + "------>" + "Invalid");

                }
            }
        }


        public void ValidateChracters(string[] arr, string pattern) //method to validate characters
        {
            Console.WriteLine("Validating for characters:");
            Regex regex1 = new Regex(pattern);
            IterateLoop(arr, regex1);

        }
       

    }
}


