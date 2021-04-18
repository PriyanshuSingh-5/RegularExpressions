using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {     

            Console.WriteLine("-------Welcome To User Registration--------");
            Console.WriteLine();
            string pattern = "^[A-Za-z0-9]{8,}$"; //pattern for password minimum 8 char.

            Program p = new Program(); // create object
            p.ValidPass(pattern);
            Console.WriteLine();
            Console.Read();
        }

        public void ValidPass(string pattern) //method to validate string
        {

            Console.WriteLine("Validation Of The Password");
            Regex regex = new Regex(pattern);
            IterateLoop(regex);  //calling method
        }

        public void IterateLoop(Regex regex)
        {
            int i = 0; //initialize i value
            while (i != 1)
            {
                Console.WriteLine("Enter Password");
                string Password = Console.ReadLine();
                bool result = regex.IsMatch(Password);  //call the IsMatch metod to determine whether a match is present

                if (result == true)  ////check result is true or not using if and hence using bool
                {
                    Console.WriteLine("Valid password");
                    i = 1;
                }
                else
                {
                    Console.WriteLine("Enter minimum eight character");
                }

            }
        }

    }
}

