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
            for (int i = 1; i <= 20 ; i++) //20 numbers
            {
                numbers.Add(Generator.Next(10, 21));
            }

            foreach (int name in numbers)
            {
                Console.WriteLine();
            }
            foreach (int name in numbers)
            {
                Console.WriteLine($"{name}");
            }







        }
    }
}
