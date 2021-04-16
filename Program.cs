using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "^[0-9]*[a-zA-Z]{3,}[a-zA-Z0-9]*$"; //Pattern for characters

            string pincode = "^[0-9]{3}[ ]*[0-9]{3}$"; //Pattern for  pin code

            string[] inputs1 = { "111", "1aaa", "aa11", "bcc", "1a1aab", "1abb23a" };
            string[] inputs2 = { "123456", "A87654", "12345B", "1N123G", "1234567", "1234" };

            Program p = new Program();
            p.ValidateChracters(inputs1, pattern);
            p.ValidatePincode(inputs2, pincode);

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

        
        public void ValidateChracters(string[] arr, string pincode) //method to validate characters
        {
            Console.WriteLine("Validating for characters:");
            Regex regex1 = new Regex(pincode);
            IterateLoop(arr, regex1);
           
        }
         public void ValidatePincode(string[] arr, string pincode) //method to validate pincode
        {
            Console.WriteLine("Validating  pin code:");
            Regex regex2 = new Regex(pincode);
            IterateLoop(arr, regex2);
           
        }

    }
}

