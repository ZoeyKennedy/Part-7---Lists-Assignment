using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Part_7___Lists_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Generator = new Random();



            List<int> numbers = new List<int>() {};
            for (int i = 1; i <= 25 ; i++) //20 numbers
            {
                numbers.Add(Generator.Next(10, 21));
            }

            foreach (int name in numbers)
            {
                Console.WriteLine();
            }

            //foreach (int name in numbers)
          //  {
           //     Console.WriteLine($"{name}");//name stays the same
           // }

            Console.WriteLine();
            Console.WriteLine(numbers[6]);
            Console.WriteLine(numbers[8]);

            string choice = "";

            while (choice != "q")
            {
                foreach (int name in numbers)
                {
                    Console.Write(($"{name}") + " ");//name stays the same 
                }
                // Console.Clear(); // Optional
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Welcome to my generic menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Sort numbers");
                Console.WriteLine("2 - Generate new numbers 2");
                Console.WriteLine("...");
                Console.WriteLine("x - Menu Option x");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    //Do option 1
                    Console.WriteLine("You chose option 1");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    numbers.Sort();
                    foreach (int name in numbers)
                    {
                        Console.Write(($"{name}") + " ");//name stays the same 
                    }
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    numbers.Clear();
                    for (int i = 1; i <= 25; i++) //20 numbers
                    {
                        
                        numbers.Add(Generator.Next(10, 21));
                    }
                    foreach (int name in numbers)
                    {
                        Console.Write(($"{name}") + " ");//name stays the same 
                    }
                    Console.ReadLine();

                }
                // Add an else if for each valid choice...

                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }


        }
    }
}
