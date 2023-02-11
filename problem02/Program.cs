// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Число {number1} больше, чем число {number2}");
} else if (number2 > number1)
{
    Console.WriteLine($"Число {number2} больше, чем число {number1}");
} else
{
    Console.WriteLine($"Числа {number2} и {number1} равны");  // не было в задании, было только "больше"
}