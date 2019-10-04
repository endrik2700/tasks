using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {   // TASK 1
            /*
            Console.WriteLine("Hello! Enter the number to be checked");
            string text = Console.ReadLine();
            if (text.Contains("-") == true)
            {
                Console.WriteLine("Your input is a negative");
            }
            else if (int.Parse(text) == 0)
            {
                Console.WriteLine("Your input is 0");
            }
            else if (text.Contains("-") == false)
            {
                Console.WriteLine(" Your input is positive");

            }
            else
            {
                Console.WriteLine("You might have not entered a number");
            }
            Console.ReadLine();
            */
            // TASK 2
            /*
            Console.WriteLine("Hello! Enter the number to be checked");
            string input = Console.ReadLine();
           
            int nr = int.Parse(input);
            if (nr%5 ==0 && nr%11 ==0) {
                Console.WriteLine(" The number does divide with 5 and 11");
            }
            else
            {
                Console.WriteLine(" The number does not divide with 5 and 11");
            }
            Console.ReadLine();*/
            /*
            // TASK 3
            string input = Console.ReadLine();
            int nr = int.Parse(input);
            if (nr%2==0)
            {
                Console.WriteLine(" The number is even");
            }
            else
            {
                Console.WriteLine(" The number is odd");
            }*/
            // TASK 4 
            /*
            Console.WriteLine("Hello! Enter the letter (one letter only) to be checked");
            string input = Console.ReadLine();
            if ( input =="a" || input =="e" || input =="i" || input =="o" || input == "u") {
                Console.WriteLine("The character is a vowel");
            } else
            {
                Console.WriteLine("The character is not a vowel");
            }
            Console.ReadLine();
            */
            //Tasks 5

            Console.WriteLine("Hello! Enter the number between 1-7 to be checked");
                string input = Console.ReadLine();
                int nr = int.Parse(input);
                switch (nr)
            {
                case  1:
                    Console.WriteLine("It's Monday");
                    break;
               
                  case 2:
                    Console.WriteLine("It's Tuesday");
                   break;
                case 3:
                    Console.WriteLine("It's Wednessday");
                    break;
                case 4:
                    Console.WriteLine("It's Thursday");
                    break;
                case 5:
                    
                    Console.WriteLine(" It's Friday");
                    break;
                case 6:

                    Console.WriteLine("It's Saturday");
                    break;
                case 7:

                    Console.WriteLine("It's Sunday");
                    break;
            }
            Console.ReadLine();
            }





    }
}
