//Задача 4: * Напишите программу, которая заполнит спирально квадратный массив.


int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,,] CreateArray(int height, int width, int depth)
{
    int[,,] array3D = new int[height, width, depth];
    return array3D;
}

void FillingArray(int[,,] array3D, int lefntRangeValue, int rightRangeValue)
{
    Random rnd = new Random(((int)DateTime.Now.Ticks));
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for(int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = rnd.Next(lefntRangeValue, rightRangeValue);
            }
        }
    }
}

void PrintArrayInConsole(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for(int k = 0;k < array3D.GetLength(2);k++)
            {
                Console.Write($"{array3D[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


int height = InputNumberWithMessage("Введите количество строк массива: ");
int width = InputNumberWithMessage("Введите количество колонок массива: ");
int depth = InputNumberWithMessage("Введите глубину массива: ");

int[,,] array3D = CreateArray(height, width, depth);
FillingArray(array3D, 1, 100);
PrintArrayInConsole(array3D);
System.Console.WriteLine();


