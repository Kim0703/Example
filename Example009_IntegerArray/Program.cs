using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int index, max, lenght;
        int[] n = new int[5];
        
        lenght = n.Length;
        index = 0;
        max = 0;
        while (index < lenght)
        {
            Console.WriteLine("Введите ваше число: ");
            n[index] = (int) inputValue();
            if (n[index] > max)
            {
                max = n[index];
            }
            index = index + 1;
        }
        Console.WriteLine(max);
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
