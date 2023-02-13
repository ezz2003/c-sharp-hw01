// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

// --------  Вариант 1 -------------
// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int number3 = Convert.ToInt32(Console.ReadLine());
// if (number2 > number1)
// {
  // number1 = number2;
// }
// if (number3 > number1)
// {
  // number1 = number3;
// }
// Console.WriteLine($"Наибольшее из чисел - {number1}");
// 

// ------------- Вариант2 --------------------
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
{
  max = number2;
}
if (number3 > max)
{
  max = number3;
}
Console.WriteLine($"Наибольшим из чисел {number1}, {number2}, {number3} является {max}");