/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
            arr[i, j] = randomArr.Next(1, 5);
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
int[,] summaArrya(int[,] arrOne, int[,] arrTwo)
{
    int[,] arrThree = new int[arrOne.GetLength(0), arrOne.GetLength(1)];
    for (int i = 0; i < arrOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrOne.GetLength(1); j++)
        {
            arrThree[i, j] = 0;
            for (int b = 0; b < arrOne.GetLength(0); b++)
            {
                arrThree[i, j] += arrOne[i, b] * arrTwo[b, j];
            }
        }
    }
    return arrThree;
}

int ArrLineOne = ConsoleInput("Введите количество строк первой матрици");
int ArrColummOne = ConsoleInput("Введите количество столбцов первой матрици ");
int[,] arrOne = ArrayPadding(ArrLineOne, ArrColummOne);
int ArrLineTwo = ConsoleInput("Введите количество строк второй матрици");
int ArrColummTwo = ConsoleInput("Введите количество столбцов второй матрици");
int[,] arrTwo = ArrayPadding(ArrLineTwo, ArrColummTwo);
PrintArray(arrOne);
Console.WriteLine(" ");
PrintArray(arrTwo);
Console.WriteLine(" ");
int[,] arrResult = summaArrya(arrOne, arrTwo);
PrintArray(arrResult);