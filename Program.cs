using System;

namespace problem1_csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //create var number 1
            //create var number 2
            //create number1input = TryParse
            //create number2input = Tryparse
            //check if statement is true (number 1 > number 2)
            //out put back to user.


            //Start the program with Clear();
            Console.Clear();

            Console.WriteLine("This program will check if number 1 and number 2 and see which one is greater");
            var number1 = 0;
            var number2 = 0;

            Console.WriteLine("Enter a number:");
            var number1input = int.TryParse(Console.ReadLine(), out number1);

            Console.WriteLine("Enter a number:");
            var number2input = int.TryParse(Console.ReadLine(), out number2);

            if (number1 > number2)
            {
                Console.WriteLine("Number 1 is greater than Number 2");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Number 2 is greater than number 1");
                Console.ReadLine();
            }
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
            
            

            

            
            
            
        }
    }
}
