// 7.Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("enter a three digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int unit = number % 10;

Console.WriteLine($"there are {unit} units among {number}");
