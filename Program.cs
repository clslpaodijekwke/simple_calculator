internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Write number 1: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Write number 2: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Choose Add, Sub, Mult, Div: ");
        string c = Console.ReadLine();

        if (c == "Add")
            Console.Write(a + b);

        else if (c == "Sub")
            Console.Write(a - b);

        else if (c == "Mult")
            Console.Write(a * b);

        else if (c == "Div")
            if (b == 0)
                Console.Write("Error");
            else
                Console.Write(a / b);
        else
            Console.Write("Error");

        Console.ReadKey();
    }
}