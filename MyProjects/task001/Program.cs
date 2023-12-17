// задать двумерный массив 5x5 от 0 до 9, 
// найти элементы у которых оба индекса четные
// и заменить эти элементы на их квадраты 

using System.ComponentModel.DataAnnotations;
using System.Data;

int[,] Create2DArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(min, max + 1);
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
            System.Console.Write(array[i,j] + " ");
        } 
        System.Console.WriteLine();
    }
}

int[,] EvenNumbersInASquare(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = array[i, j]  * array[i, j];
            }
        } 
    }
    return array;
}

int[,] myArray = Create2DArray(5,5,0,9);
Print2DArray(myArray);
myArray = EvenNumbersInASquare(myArray);
System.Console.WriteLine();
Print2DArray(myArray);