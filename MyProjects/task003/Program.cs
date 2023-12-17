// задать двумерный массив  целых чисел
// затем создать новый одномерный массив состоящий из
// среднего арифметического по строкам двумерного массива

int[,] Create2DArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

double[] SredArifmet(int[,] array)
{
    double[] celoe = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        celoe [i] = sum/array.GetLength(1);
    }
    return celoe;
}

void PrintIntArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int[,] myArray = Create2DArray(5, 5, 0, 9);
Print2DArray(myArray);
System.Console.WriteLine();
PrintIntArray(SredArifmet(myArray));