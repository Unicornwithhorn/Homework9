// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
string NumbersInRow(int N)
{
  if (N == 1) return "1";
  return N + " " + NumbersInRow(N-1);
}

System.Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(NumbersInRow(N));