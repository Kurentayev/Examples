
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("УРА, это же маша");
}
else 
{
    Console.WriteLine("ПРИВЕТ, ");
    Console.WriteLine(username);
}
