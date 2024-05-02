
//1. Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//Использовать рекурсию.
Console.Clear();

void PrintNaturalNumbers(int m, int n)
{
    if (m >= n)
    {
        Console.Write(m + " ");
        PrintNaturalNumbers(m - 1, n);
    }
    else {Console.Write("ошибка, число M < числа N");}
}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumbers(M, N);