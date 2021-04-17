using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user Registration");
            string pattern = "^[0-9]{2}[ ]*[0-9]{10}$"; //Pattern for characters

            //Pattern for  Phone number

            string[] inputs1 = { "91 8978674532", "987654320981", "9876543212431", "91 8907562431", "990088776655", "990088awek678543" };
            

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


