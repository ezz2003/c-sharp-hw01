// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

Console.Write("Введите ваше число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= number)       // включая "N"
{
  if (!Convert.ToBoolean(count % 2))
  {
    Console.Write($"{count} ");
  }
  count++;
}