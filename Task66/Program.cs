// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Sum(int M, int N)
{
  if (M == N) return N;
  else if (M > N) return M + Sum(M - 1, N);
  else return M + Sum(M + 1, N);
}

Console.WriteLine("Введите два числа");
int[] size = Console.ReadLine()!.Split().Select(k => int.Parse(k)).ToArray();
System.Console.WriteLine(Sum(size[0],size[1]));

