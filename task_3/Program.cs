// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
            array[i, j] = rnd.Next(1, 6);
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

// Метод умножения матриц

int[,] MultiMatrix(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] multiArray = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            for (int k = 0; k < arrayOne.GetLength(1); k++)
            {
                multiArray[i, j] += arrayOne[i, k] * arrayTwo[k, j];
            }
        }

    }
    return multiArray;
}

(int row, int col) = InputSizeArray("Введите количество строк первой матрицы", "Введите количество столбцов первой матрицы");
(int a, int b) = InputSizeArray("Введите количество строк второй матрицы", "Введите количество столбцов второй матрицы");
int[,] arrayOne = AddArray(row, col);
FillArray(arrayOne);
PrintArray(arrayOne);
System.Console.WriteLine("______________");
int[,] arrayTwo = AddArray(a, b);
FillArray(arrayTwo);
PrintArray(arrayTwo);
System.Console.WriteLine("______________");
PrintArray(MultiMatrix(arrayOne, arrayTwo));
