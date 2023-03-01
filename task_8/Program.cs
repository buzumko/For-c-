// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа
// поскольку нет условия, может ли число быть = 1, считаем, что может
Console.Write("Введите целое число: ");
int userNumber = int.Parse(Console.ReadLine() ?? "");

///////////////

if (userNumber == 1)
{
    Console.Write($"Четных чисел нет в указанном промежутке");
}
else
{
    for (int index = 1; index <= userNumber; index++)
    {
        if (index % 2 == 0)
        {
            Console.Write($"{index} ");
        }
    }
}
