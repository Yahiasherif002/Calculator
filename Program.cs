internal class Program
{
    private static void Main(string[] args)
    {
        int num1;
        int num2;

        String answer;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Hello, Welcome to the calculator!");

        Console.WriteLine("Enter the first number : ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number : ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What type of operation you would like to do");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        answer = Console.ReadLine();

        switch (answer)
        {
            case "1":
                Console.WriteLine("The result is : " + (num1 + num2));
                break;
            case "2":
                Console.WriteLine("The result is : " + (num1 - num2));
                break;
            case "3":
                Console.WriteLine("The result is : " + (num1 * num2));
                break;
            case "4":
                Console.WriteLine("The result is : " + (num1 / num2));
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }


        Console.ReadKey();  

    }
}