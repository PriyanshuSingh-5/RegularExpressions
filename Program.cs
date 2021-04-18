﻿using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {     //Entery point 

            Console.WriteLine("-------Welcome To User Registration--------");
            Console.WriteLine();
            string pattern = "[0-9]{1}"; //pattern for atleast 1numeric password 

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
                    Console.WriteLine("Enter atlest one numeric number");
                }

            }
        }

    }
}

