//№52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
//столбце.

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

//Среднее арифметическое в столбце
double [] AvgColum(int[,] arr)
{
    double []avr = new double [arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
     double summ = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
           summ += arr[i,j];
        }
        avr[j]=summ/arr.GetLength(0);
        Console.WriteLine("Среднее арифметическое столбца " +(j+1)+" равно: "+avr[j]);
    }
    return avr;   
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
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

//Метод, выводящий на печать массив
void PrintArr( double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}


int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArrayColor(arr2D);
double[] avgCol = AvgColum(arr2D);
PrintArr(avgCol);

// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным цветом. Частично(((


// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// // Универсальный метод генерации и заполнение двумерного массива
// int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
// {
//     System.Random rand = new System.Random();
//     int[,] array2D = new int[countRow, countColumn];
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             array2D[i, j] = rand.Next(topBorder, downBorder + 1);
//         }
//     }
//     return array2D;
// }

// //ср ариф диагонали
// double AvgDiag(int[,] arr)
// {
//     double summ = 0;
//     int min = arr.GetLength(0);
//     for (int i = 0; i < min; i++)
//     {
//         summ += arr[i, i];
//     }
// double avg = summ/min;
// Console.ForegroundColor = ConsoleColor.Green;
// Console.WriteLine($"Среднее арифметическое диагонали с началом в столбце 1 и строке 1 равно {avg}");
// Console.ResetColor();
// return avg;  // результат пока так. пока не придумала что именно вернуть чтобы подставить и расскрасить
// }

// //ср ариф диагонали
// double AvgDiag2(int[,] arr)
// {
//     double summ = 0;
//     int count=0;
//     double avg = 0;
//     int min = arr.GetLength(0);
//     for (int N = 1; N < min; N++)
//     {
//     for (int i = 0; i < min-N; i++)
//         {
//         summ += arr[i, i+N];
//         count++;
//         }
//     avg = summ/count;
//     Console.WriteLine($"Среднее арифметическое диагонали с началом в строке 1 , столбце {N+1} {avg}");
//     }
// return avg;  // результат пока так. пока не придумала что именно вернуть чтобы подставить и расскрасить
// }

// //ср ариф диагонали
// double AvgDiag3(int[,] arr)
// {
//     double summ = 0;
//     int count=0;
//     double avg = 0;
//     int min = arr.GetLength(1) ;
//     for (int N = 1; N < min; N++)
//     {  
//     for (int i = 0; i < min-N; i++)
//         {
//         summ += arr[i+N, i];
//         count++;
//         }    
//     avg = summ/count;
//     Console.WriteLine($"Среднее арифметическое диагонали с началом в столбце 1, строке {N+1} {avg}");
//     }
// return avg; // результат пока так. пока не придумала что именно вернуть чтобы подставить и расскрасить
// }

// void Print2DArrayColor(int[,] matrix)
// {
//     ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                         ConsoleColor.Yellow};
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//        for (int j = 0; j < matrix.GetLength(1); j++)         {
//         Console.ForegroundColor = col[new System.Random().Next(0, 16)];
           
//         Console.Write(matrix[i, j] + "   ".Substring(matrix[i, j].ToString().Length));
//         Console.ResetColor();
//         }
//         Console.WriteLine();
//     }
// }



// int row = ReadData("Введите количество строк ");
// int column = ReadData("Введите количество столбцов ");
// int[,] arr2D = Fill2DArray(row, column, 10, 99);
// Print2DArrayColor(arr2D);
// AvgDiag(arr2D);
// AvgDiag2(arr2D);
// AvgDiag3(arr2D);







