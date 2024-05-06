using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

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

            int removeNumber;
            int addNum;
            bool deleteNum;

            while (choice != "q")
            {
                foreach (int name in numbers)
                {
                    Console.Write(($"{name}") + " ");//name stays the same 
                }
                // Console.Clear(); // Optional
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Sort numbers");
                Console.WriteLine("2 - Generate new numbers");
                Console.WriteLine("3 - Remove numbers");
                Console.WriteLine("4 - Add a number");
                Console.WriteLine("5 - Count the occurances of a specified number");
                Console.WriteLine("6 - PRint the largest value");
                Console.WriteLine("...");
                Console.WriteLine("x - Menu Option x");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1") // how to sort the new numbers instead of the old ones?
                {
                    // Sort numbers
                    Console.WriteLine("You chose option 1");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    numbers.Sort();
                    foreach (int name in numbers)
                    {
                        Console.Write(($"{name}") + " ");
                    }
                    Console.ReadLine();
                }
                else if (choice == "2") 
                {
                    // Generate new numbers
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    numbers.Clear();
                    for (int i = 1; i <= 25; i++) 
                    {
                        
                        numbers.Add(Generator.Next(10, 21));
                    }
                    foreach (int name in numbers)
                    {
                        Console.Write(($"{name}") + " ");
                    }
                    Console.ReadLine();
                    
                }
                else if (choice == "3")
                {
                    // Remove a number
                    Console.WriteLine("You chose option 3");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    Console.WriteLine("What number would you like to remove?");
                        removeNumber = Convert.ToInt32(Console.ReadLine());

                  for (int i = numbers.Count - 1; i >= 0; i-- )
                    {
                        if (numbers[i] == removeNumber)
                            numbers.RemoveAt(i);

                    }
                  foreach (int name in numbers)
                    {
                        Console.Write(" " + $"{name}" + " ");
                    }

                    Console.ReadLine();

                }
                else if (choice == "4")
                {
                    Console.WriteLine("You chose option 4");
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();

                    Console.WriteLine("Enter the number you want to add. It needs to be between 10 and 25.");
                    addNum = Convert.ToInt32(Console.ReadLine());
                    while (addNum >=26 || addNum <= 9)
                    {
                        Console.WriteLine("The number must be between 10 and 25");
                        addNum = Convert.ToInt32(Console.ReadLine());
                            
                    }
                    numbers.Add(addNum);
                    foreach (int name in numbers)
                    {

                        Console.Write(" " + $"{name}" + " ");
                    }
                    Console.ReadLine();
                }
                
                else if (choice == "5")
                {
                    //Count number of occurances of a specified number
                    int countOccurances;
                    int counter;
                    counter = 0;
                    Console.WriteLine("You chose option 5");
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();
                    Console.WriteLine("What number do you want to count the occurances of?");
                    countOccurances = Convert.ToInt32(Console.ReadLine());
                    for (int i = numbers.Count - 1; i >= 0; i--)
                    {
                        if (numbers[i] == countOccurances)
                            counter = counter + 1;
                        

                    }
                    Console.WriteLine("number of occurances of the number " + countOccurances + ": " + counter);

                    Console.ReadLine();

                }
                else if (choice == "6")//print the largest value
                {
                    int largestValue;
                    largestValue = 0;
                      for (int i = numbers.Count - 1; i >= 0; i--)
                    { 
                        if (numbers[i] > numbers[i] - 1)
                        {
                            largestValue = numbers[i];
                        }
                        
                    }
                        Console.WriteLine("The largest value in the list is " + largestValue);
                        Console.ReadLine();
                  

                }
                else if (choice == "7")
                {

                }

                else if (choice == "8")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
                // Add an else if for each valid choice...







            }


        }
    }
}
