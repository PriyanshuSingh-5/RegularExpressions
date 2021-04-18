using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {      

            Console.WriteLine("Welcome To User Registration");
            Console.WriteLine();
            string Pattern = "^([a-z]{3,})([.]{0,1}[a-z]*)@([a-z]{2}).([a-z]{2})([.]{1}[a-z]{2}){0,1}$"; //pattern using for email.

            Program p = new Program(); // create object
            p.ValidName(Pattern);
            Console.WriteLine();
            Console.Read();
        }

        public void ValidName(string Pattern) //method to validate string
        {
            Console.WriteLine("Validation Of The Email");
            Regex regex = new Regex(Pattern);
            IterateLoop(regex);  //calling method
        }

        public void IterateLoop(Regex regex)
        {
            int i = 0; 
            while (i != 1)
            {
                Console.WriteLine("Enter Email");
                string email = Console.ReadLine();
                bool result = regex.IsMatch(email);  //call the IsMatch metod to determine whether a match is present

                if (result == true)  ////check result is true or not using if and hence using bool
                {
                    Console.WriteLine("Valid email");
                    i = 1;
                }
                else
                {
                    Console.WriteLine("Enter email in this format : abc.xyz@bl.co.in");
                }

            }
        }
    }
}

