/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int ConsoleInput(string messange)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(messange);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Ввели не число. ");
        }
    }
}


int[,] ArrayPadding(int line, int columm)
{
    int[,] arr = new int[line, columm];
    Random randomArr = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = randomArr.Next(1, 10);
        }
    return arr;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();

    }
}
void LowesAtmount(int[,] array)
{
    int[] arr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int result = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j];
        }
        arr[i]=result;
    }
    int minLine = findMinLine(arr);
    Console.WriteLine($"Сумма элементов = {arr[minLine]}, строка {minLine+1}");
}

int findMinLine(int[] arr)
{
    int min = arr[0];
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= min)
        {
            result = i;
        }
    }
    return result;
}



int ArrLine = ConsoleInput("Введите количество строк ");
int ArrColumm = ConsoleInput("Введите количество столбцов ");
int[,] arr = ArrayPadding(ArrLine, ArrColumm);
PrintArray(arr);
LowesAtmount(arr);