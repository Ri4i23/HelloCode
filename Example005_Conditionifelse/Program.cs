Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "катюша")
{
    Console.WriteLine("Ура, это же Катюша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}