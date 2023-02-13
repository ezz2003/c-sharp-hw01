// Задача 6: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (Convert.ToBoolean(number % 2))                      // (number % 2 != 0)
{
  Console.WriteLine($"число {number} - нечётное");
}
else 
{
  Console.WriteLine($"число {number} - чётное");
}