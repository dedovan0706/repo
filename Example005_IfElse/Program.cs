Console.Write("Введите имя пользователя: ");
string? username = Console.ReadLine();

if (username.ToLower()  == "наташа")
{
   Console.Write ("Ура, это же Наташа");   
}
else
{
   Console.Write ("Привет, ");
   Console.WriteLine (username); 
}