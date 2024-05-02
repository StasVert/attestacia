//3. Задайте произвольный массив. Выведите его элементы, начиная с конца. Использовать рекурсию.

int[] MyArray = {1, 5, 9, 10};

// for(int i = myArray.Length - 1; i >= 0; i--)

void PrintArray(int[] MyArray, int i = 3)
{
    if (i >= 0)
    {
       System.Console.WriteLine(MyArray[i]);
       PrintArray(MyArray, i - 1);
    }
}

PrintArray(MyArray);