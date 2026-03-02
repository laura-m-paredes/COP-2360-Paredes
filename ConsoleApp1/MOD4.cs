class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter second number: ");
        string input2 = Console.ReadLine();

        MainMain(input1, input2);
    }

    static void MainMain(params string[] args)
    {
        try
        {
            byte b1 = byte.Parse(args[0]);
            byte b2 = byte.Parse(args[1]);
            int result = Calc(b1, b2);
            Console.WriteLine("Result: " + result);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Please provide at least two arguments");
        }
        catch (FormatException)
        {
            Console.WriteLine("That's not a number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("You've given me more than a byte!");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("You can't divide by zero!");
        }
    }

    static int Calc(int b1, int b2) { return b1 / b2; }
}