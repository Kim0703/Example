Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "лариса")
{
    Console.WriteLine("Ура это же ЛАРИСА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}