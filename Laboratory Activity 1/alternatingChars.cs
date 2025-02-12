using System;

public class SquarePattern
{
    public static void Main(string[] args)
    {
        Console.Write("First character: ");
        char firstChar = Console.ReadKey().KeyChar;
        Console.ReadLine();
        Console.Write("Second character: ");
        char secondChar = Console.ReadKey().KeyChar;
        Console.ReadLine();
        Console.Write("Enter size: ");
        int size = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= size; i++)
        {
            Console.Write(new string('-', (i - 1)));
            
            if (i % 2 == 0)
            {
                Console.WriteLine(secondChar);
            }
            else
            {
                Console.WriteLine(firstChar);
            }
        }
    }
}
