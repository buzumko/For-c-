// Задача 2: 
// Напишите программу, которая на вход принимает 2 числа и выдаёт, какое число большее, а какое меньшее

Console.Write("Введите первое целое число: ");
int user_number_one = int.Parse(Console.ReadLine() ?? "");

//////////////

Console.Write("Введите второе целое число: ");
int user_number_two = int.Parse(Console.ReadLine() ?? "");

///////////////

if (user_number_one == user_number_two)
{
    Console.WriteLine($"числа {user_number_one} и {user_number_two} равны");
}
else
{
    if (user_number_one > user_number_two)
    {
        Console.WriteLine($"max = {user_number_one}, min = {user_number_two}");
    }
    else
    {
        Console.WriteLine($"max = {user_number_two}, min = {user_number_one}");
    }
}
