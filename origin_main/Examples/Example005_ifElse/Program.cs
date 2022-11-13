//Напишите программу, которая будет приветствовать пользоватя Маша по сособенному, остальных обычно

Console.WriteLine("Введите имя пользователя");
String username = Console.ReadLine() ??"";

if(username.ToLower() == "маша")
{
Console.WriteLine("Ура, это же Маша");
}
else
{
   Console.WriteLine("Привет, ");
   Console.WriteLine(username);
}