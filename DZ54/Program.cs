/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
    for (int i = 0; i < line; i++)
        for (int j = 0; j < columm; j++)
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

int[,] BubbleMethod(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        for (int f = 0; f < array.GetLength(1) - j - 1; f ++)    
        
        {
            if (array[i, f] < array[i, f + 1])
            {
                int timeArr = array[i,f];
                array[i,f] = array[i, f + 1];
                array [i, f +1] = timeArr;
                
            }
        }
        return array;


}
int ArrLine = ConsoleInput("Введите количество строк ");
int ArrColumm = ConsoleInput("Введите количество столбцов ");
int[,] arr = ArrayPadding(ArrLine, ArrColumm);
PrintArray(arr);
BubbleMethod(arr);
Console.WriteLine("В итоге получается вот такой массив:");
PrintArray(arr);