// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое целое число: ");
int user_number_one = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе целое число: ");
int user_number_two = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите третье целое число: ");
int user_number_three = int.Parse(Console.ReadLine() ?? "");
int maximum = user_number_one;

///////////////

if (maximum < user_number_two)
{
    maximum = user_number_two;
}
if (user_number_three > maximum)
{
    maximum = user_number_three;
}

Console.WriteLine($"max = {maximum}");

