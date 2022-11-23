Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "люся")
{
    Console.WriteLine("Ура, это же Люся!!!");
}
else
{
    Console.Write("Привет! ты пидор - ");
    Console.WriteLine(username);
}