// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
Console.Write("Введите целое число: ");
int user_number_one = int.Parse(Console.ReadLine() ?? "");

///////////////

if (user_number_one % 2 == 0)
{
    Console.WriteLine($"число {user_number_one} четное");
}
else
{
    Console.WriteLine($"число {user_number_one} нечетное");
}
