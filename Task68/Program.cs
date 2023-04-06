// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int Ackermann(int m, int n)
{
  if (m == 0) return n+1;
  else if (m > 0 && n == 0) return Ackermann(m-1, 1);
  else if (m > 0 && n > 0) return Ackermann(m-1, Ackermann(m, n-1));
  else return -1;
}                      

Console.WriteLine("Введите два числа");
int[] size = Console.ReadLine()!.Split().Select(k => int.Parse(k)).ToArray();
double result = Ackermann(size[0],size[1]);
if (result == -1) System.Console.WriteLine("Функция не определяеся для заданных значений");
else System.Console.WriteLine(result);
