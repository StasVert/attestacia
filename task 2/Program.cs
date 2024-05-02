//2. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();

int A(int m, int n)
{
    if (m == 0)         return n + 1;
    else if (n == 0)    return A(m - 1, 1);
    else                return A(m - 1, A(m, n - 1));
}

Console.Write("Значение N: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Значение M: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m >= 0 && n >= 0) Console.WriteLine(A(m, n));
else Console.WriteLine("Введите ПОЛОЖИТЕЛЬНЫЕ значения!");