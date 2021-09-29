using System;

namespace ExponentsLabYB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your square and cubes!");
            bool keepGoing = true;
            //loop to continue
            while (keepGoing == true) {

                Console.WriteLine("Enter an integer: ");
                int number = int.Parse(Console.ReadLine());
                //validation
                if(number <=0 || number > 1290)
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }
                //calling method
                PowersTable(number);
                Console.WriteLine("Would you like to continue? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "n")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }
        //math method
        public static void PowersTable(int num)
        {
            //math
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Number\tSqaured\tCubed");
                Console.WriteLine("=====\t=====\t=====");
                int square = i * i;
                int cube = i* i * i;
                Console.WriteLine($"{i, 5} \t {square, 5} \t {cube, 5}"); //aligns right by 5
            }
        }
        
    }
    
}
