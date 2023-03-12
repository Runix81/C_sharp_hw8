// Напишите программу, которая заполнит спирально квадратный массив.

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

// Метод заполнения массива по спирали

int[,] StepFeelArray(int[,] array)
{
    int size = array.GetLength(0);
    int pos = 0;
    int count = size;
    int value = -size;
    int sum = -1;

    do {
        value = -1 * value / size;
        for (int i = 0; i < count; i++) {
            sum += value;
            array[sum / size, sum % size] = pos++;
        }
        value *= size;
        count--;
        for (int i = 0; i < count; i++) {
            sum += value;
            array[sum / size, sum % size] = pos++;
        }
    } while (count > 0);

    return array;
    
}

(int row, int col) = InputSizeArray("Введите количество строк", "Введите количество столбцов");
int[,] array = AddArray(row, col);
StepFeelArray(array);
PrintArray(array);