// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



int row = ReadData("Введите количество строк 1 матрицы:  ");
int colRow = ReadData("Введите количество столбцов матрицы 1 (строк второй): ");
int column = ReadData("Введите количество столбцов матрицы 2 : ");
int range = ReadData("Введите диапазон значений массива: от 1 до ");

int[,] firstMartrix = Fill2DArray(row, colRow, 1, range);
Console.WriteLine($"\nПервая матрица:");
Print2DArrayColor(firstMartrix);
Console.WriteLine($"\nВторая матрица:");
int[,] secomdMartrix = Fill2DArray(colRow, column, 1, range);
Print2DArrayColor(secomdMartrix);

int [,] resultMatrix = MultiplyMatrix(firstMartrix, secomdMartrix, row, column);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
Print2DArrayColor(resultMatrix);

//перемножение матриц
int [,] MultiplyMatrix(int[,] array1, int[,] array2, int row, int column)
{
    int[,] arrayMult = new int[row, column];
    for (int i = 0; i < arrayMult.GetLength(0); i++)
    {
        for (int j = 0; j < arrayMult.GetLength(1); j++)
        {
            int mult = 0;
        for (int k = 0; k < array1.GetLength(1); k++)
            {
                mult += array1[i,k] * array2[k,j];
            }
            arrayMult[i,j] = mult;
        }
    }
    return arrayMult;
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

