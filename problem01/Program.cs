﻿// Итерация №1
// Решение в группах задач:
// 1.Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5->да
// a = 2, b = 10->нет
// a = 9, b = -3->да
// a = -3 b = 9 -> нет
// 
// 

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 * number2 == number1)
{
  Console.WriteLine($" число {number1} является квадратом числа {number2}");
}
else
{
  Console.WriteLine($" число {number1} не является квадратом числа {number2}");
}
