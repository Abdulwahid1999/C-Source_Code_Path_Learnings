namespace Calculator_Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellow!");

            /*    Console.Write("Input the first number:");
                int number1 = Convert.ToInt32(Console.ReadLine()); 

                Console.Write("Input the Second number:");
                int number2 = Convert.ToInt32(Console.ReadLine());*/

            Console.WriteLine("Hellow!");
            Console.WriteLine("Inputs the first number:");
            string firstNumber = Console.ReadLine();
            int number1 = int.Parse(firstNumber);

            Console.WriteLine("Inputs the second number:");
            string secondNumber = Console.ReadLine();
            int number2 = int.Parse(secondNumber);

            Console.WriteLine("What do you want to do with those numbers?");
            Console.WriteLine("[A]dd");
            Console.WriteLine("[S]ubtract");
            Console.WriteLine("[M]ultiply");

            string inputs = Console.ReadLine();

            switch (inputs)
            {
                case "A" or "a":
                    var addition = number1 + number2;
                    Console.WriteLine($"{number1} + {number2} = {addition}");
                    break;

                case "S" or "s":
                    var subtract = number1 - number2;
                    Console.WriteLine($"{number1} - {number2} = {subtract}");
                    break;

                case "M" or "m":
                    var multiply = number1 * number2;
                    Console.WriteLine($"{number1} * {number2} = {multiply}");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
