using System;



namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 5]
            {
                {2, 56,17,45,67},
                {43,56,926,768,2},
                {61,176, 945,430,44},
            };
            
            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}