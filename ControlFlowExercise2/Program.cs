using System;

namespace ControlFlowExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number, any number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me another number: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                Console.WriteLine($"{numberOne} is larger.");
            }
            else
            {
                Console.WriteLine($"{numberTwo} is larger.");
            }
        }
    }
}
