// Console.WriteLine("Input three digit number");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = num % 10;

// while (num < 100 && num > -100)
// {
//     Console.WriteLine("Input three digit number");
//     num = Convert.ToInt32(Console.ReadLine());
//     if (num >= 100 && num <= 999 || num >= -100 && num <= -999)
//     {
//         result = num % 10;
//         Console.WriteLine($"Last digit number of {num} is {result}");
//     }
//     else
//     {
//         Console.WriteLine("Input three digit number");
//         num = Convert.ToInt32(Console.ReadLine());
//     }
// }

// while (num > 999 && num < -999)
// {
//     Console.WriteLine("Input three digit number");
//     num = Convert.ToInt32(Console.ReadLine());
//     if (num >= 100 && num <= 999 || num >= -100 && num <= -999)
//     {
//         result = num % 10;
//         Console.WriteLine($"Last digit number of {num} is {result}");
//     }
//     else
//     {
//         Console.WriteLine("Input three digit number");
//         num = Convert.ToInt32(Console.ReadLine());
//     }   
// }
// result = num % 10;
// Console.WriteLine($"Last digit number of {num} is {result}");

while (true) // бесконечный цикл
{
    Console.WriteLine("Input three digit number");
    int num = Convert.ToInt32(Console.ReadLine());
    int number = num;
    if (num < 0) num = -num;
    if (num >= 100 && num <= 999)
    {
        Console.WriteLine($"Last digit number of {number} is {num % 10}");
        break;  // прервать цикл
    }
}