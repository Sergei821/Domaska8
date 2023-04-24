//Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] CreateArray(int row, int Columns)
{
    int[,] array2D = new int[row, Columns];
    return array2D;
}

void FillingArray(int[,] array2D, int lefntRangeValue, int rightRangeValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(lefntRangeValue, rightRangeValue);
        }
    }
}

void PrintArrayInConsole(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int RowMinSummArray2D(int[,] array2d)
{
    int[] tempArray = new int[array2d.GetLength(0)];
    int index = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            tempArray[i] += array2d[i, j];
        }        
    }
    int min = tempArray[0];
    for (int k = 0; k < tempArray.Length; k++)
    {
        if (tempArray[k] < min)
        {
            min = tempArray[k];
            index = k;
        }
    }

    return index + 1;
}

int rows = InputNumberWithMessage("Введите число строк массива: ");
int columns = InputNumberWithMessage("Введите число колонок массива: ");

int[,] array2D = CreateArray(rows, columns);
FillingArray(array2D, 1, 10);
PrintArrayInConsole(array2D);
System.Console.WriteLine();
Console.WriteLine(RowMinSummArray2D(array2D));

