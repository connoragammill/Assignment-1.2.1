namespace Assignment_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculations = true;
            while (continueCalculations)
            {
                //assignment 1.2.1
                Console.WriteLine("Assignment 1.2.1:");

                Console.WriteLine();

                Console.WriteLine("Input 1st number:");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input 2nd number:");
                int number2 = Convert.ToInt32(Console.ReadLine());
                if (number1 == number2)
                {
                    Console.WriteLine($"{number1} and {number2} are equal");
                }
                else
                {
                    Console.WriteLine($"{number1} and {number2} are not equal");
                }


            }
        }
    }
}
