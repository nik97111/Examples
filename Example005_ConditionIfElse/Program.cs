Console. WriteLine("Введите имя пользователя");
string usernaame = Console.ReadLine();

if (usernaame.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это же Маша!");
}
else 
{
    Console.Write("Привет ,");
    Console.WriteLine(usernaame);
}