/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void printArray(int[,] printArr)
{
    for (int i = 0; i < printArr.GetLength(0); i++)
    {
        for (int j = 0; j < printArr.GetLength(1); j++)
        {
            Console.Write($"{printArr[i,j]} ");
        }
    Console.WriteLine();
    }
}

int getNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result)) break;
        else Console.WriteLine("Введены не корректные данные.");
    }
    
    return result;
}

int[,] spiralArr(int amount)
{
    int[,] spiral = new int[amount,amount];
    int number = 1;
    int max = amount * amount;
    int rmin = 0, rmax = amount - 1;
    int cmin = 0, cmax = amount - 1;
    while(number <= max)
    {
        for (int i = cmin; number <= max && i <= cmax; i++) {
            spiral[rmin,i] = number++;
        }
        rmin++;
        for (int i = rmin; number <= max && i <= rmax; i++) {
            spiral[i,cmax] = number++;
        }
        cmax--;
        for (int i = cmax; number <= max && i >= cmin; i--) {
            spiral[rmax,i] = number++;
        }
        rmax--;
        for (int i = rmax; number <= max && i >= rmin; i--) {
            spiral[i,cmin] = number++;
        }
        cmin++;
    }
    return spiral;
}

int amount = getNumber("Введите размер матрицы");
int[,] matrix = spiralArr(amount);
printArray(matrix);