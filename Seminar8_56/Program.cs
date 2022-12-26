// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int row = ReadData("Введите количество строк:  ");
int column = ReadData("Введите количество столбцов: ");
int range = ReadData("Введите диапазон значений массива: от 1 до ");
int[,] arr2D = Fill2DArray(row, column, 1, range);
Print2DArrayColor(arr2D);
MinRow(arr2D);

//поиск строки с минимальной суммой элементов
void MinRow(int [,]arr)
{
int minIndex = 0;
int minRow = SumLineElements(arr, 0);
for (int i = 1; i < arr.GetLength(0); i++)
{
  int sumLine = SumLineElements(arr, i);
  if (minRow > sumLine)
  {
    minRow = sumLine;
    minIndex = i;
  }
  
}
Console.WriteLine($"\nМинимальная сумма элементов в строке равна : {minRow}");
Console.WriteLine($"Cтрокa с наименьшей суммой элементов: {minIndex+1}");
}

//Сумма элементов в строке
int SumLineElements(int[,] array, int i)
{
  int sumLine = 0;
  for (int j = 0; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

//Печать разноцветного массива
void Print2DArrayColor(int[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(matrix[i, j] + "    ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
