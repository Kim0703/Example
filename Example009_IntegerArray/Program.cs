int index, max, lenght;
int[] n = new int[5];
        
lenght = n.Length;
index = 0;
max = 0;
while (index < lenght)
{
    Console.WriteLine("Введите ваше число: ");
    n[index] = Convert.ToInt32(Console.ReadLine());
    if (n[index] > max)
    {
        max = n[index];
    }
    index++;
}
Console.WriteLine(max);