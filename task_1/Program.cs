// Задайте двумерный массив. Напишите программу, которая упорядочивает 
// по убыванию элементы каждой строки двумерного массива.

//Метод ввода количества строк и столбцов

(int row, int col) InputSizeArray(string numrow, string numcol)
{
    System.Console.Write($"{numrow} -> ");
    int row = Convert.ToInt32(Console.ReadLine());
    System.Console.Write($"{numcol} -> ");
    int col = Convert.ToInt32(Console.ReadLine());
    return (row, col);
}

// Метод создания двухмерного массива

int[,] AddArray(int row, int col)
{
    int[,] array = new int[row, col];
    return array;
}

// Метод заполнения массива

int[,] FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

// Метод вывода массива в консоль

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}    | ");
        }
        System.Console.WriteLine();
    }
}

// Метод упорядочивания значений элементов в строках массива по убыванию.

int [,] ChangeArray(int[,] array)
{
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i,k] < array[i,k+1])
                {
                    int buff = array[i,k+1];
                    array[i,k+1] = array[i,k];
                    array[i,k] = buff;
                }
            }
        }
    }
    return array;
}

(int row, int col) = InputSizeArray("Введите количество строк", "Введите количество столбцов");
int[,] array = AddArray(row, col);
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
PrintArray(ChangeArray(array));