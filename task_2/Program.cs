//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет
//  находить строку с наименьшей суммой элементов.

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

// Метод подсчета суммы значений в строках массива.

int SumNumbersOfRow(int[,] array, int i)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    return sum;
}

// Метод сравнивающий значения сумм строк

void ResultOfCompare(int[,] array)
{
    int minimumSum = SumNumbersOfRow(array, 0); 
    int[] arr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int row = SumNumbersOfRow(array, i);
        arr[i] = row;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minimumSum)
        {
            minimumSum = arr[i];
        }
    }
    System.Console.Write($"{minimumSum}");
}

(int row, int col) = InputSizeArray("Введите количество строк", "Введите количество столбцов");
int[,] array = AddArray(row, col);
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
ResultOfCompare(array);