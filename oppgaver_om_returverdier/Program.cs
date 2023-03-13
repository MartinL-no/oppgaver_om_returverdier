using System;

namespace oppgaver_om_returverdier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("TaskOne: 1 + 2 = ");
            Console.WriteLine(TaskOne(1, 2));

            Console.Write("TaskTwo return value is: ");
            Console.WriteLine(TaskTwo());
         }

        static int TaskOne(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
        static string TaskTwo()
        {
            return "Denne metoden returnerer ingenting";
        }
    
    }
}

