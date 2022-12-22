// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

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
// Метод поиска элемента
int SearchElem(int [,]arr,int x, int y)
{
    int elem = -1;
    if ((x<arr.GetLength(0)) && (y <arr.GetLength(1)))
    {
        elem = arr[x,y];
    }
  return elem;
}

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
//печать разноцветного массива
void Print2DArrayColor(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0,16)];
            Console.Write(matrix[i, j] + " ");
            Console.ResetColor(); 
        }
        Console.WriteLine();
    }
}
//Метод, выводящий на печать данные пользователю
void PrintData(int res, int x, int y)
{
    if (res > 0)
    {
    Console.WriteLine($" Элемент с координатами {x}, {y} равен {res}");
    }
    else
    {
      Console.WriteLine($" Элемента с координатами {x}, {y} не существует"); 
    }
}


int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int coorR = ReadData("Введите номер строки искомого числа ");
int coorC = ReadData("Введите номер столбца искомого числа ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);
int elem = SearchElem(arr2D,coorR,coorC);
Print2DArrayColor(arr2D);
PrintData(elem,coorR, coorC);

// //* Заполнить числами Фиббоначи и выделить цветом найденную цифру. Частично, без выделения цветом

// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// //Числа Фибоначчи
// string FibNum(int num)
// {
//     string outLine = "0 1";
//     int first = 0;
//     int last = 1;
//     int buf = 0;
//     for (int i = 2; i < num; i++)
//     {
//         outLine = outLine +" "+ (first + last).ToString();
//         buf=last;
//         last=first+last;
//         first=buf;
//     }
//     return outLine;

// }

// // и заполнение двумерного массива
// int [,] Fill2DArray(int countRow, int countColumn,  string num)
// {
    
//     int[,] array2D = new int[countRow, countColumn];
//     string [] numArr = num.Split(new char[] {' '});

//     for (int i = 0; i < array2D.GetLength(0); i++)
//     { 
        
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//              array2D[i, j] = int.Parse(numArr[new Random().Next(0,numArr.Length)]);

//             }  
//     }
// System.Console.WriteLine(array2D);
//     return array2D;
// }

// // Метод поиска элемента
// int SearchElem(int [,]arr,int x, int y)
// {
//     int elem = -1;
//     if ((x<arr.GetLength(0)) && (y <arr.GetLength(1)))
//     {
//         elem = arr[x,y];
//     }
//   return elem;
// }

// ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                         ConsoleColor.Yellow};
// //Метод вывода цветного массива
// void Print2DArrayColor(int[,] matrix, int x, int y)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//          {
       
//             Console.ForegroundColor = ConsoleColor.Red;
//             Console.Write(matrix[i, j]+"      ".Substring(matrix[i, j].ToString().Length));
//             Console.ResetColor(); 
//         }
//         Console.WriteLine();
//    }
// }
// void PrintData(int res, int x, int y)
// {
//     if (res > 0)
//     {
//     Console.WriteLine($" Элемент с координатами {x}, {y} равен {res}");
//     }
//     else
//     {
//       Console.WriteLine($" Элемента с координатами {x}, {y} не существует"); 
//     }
// }

// int row = ReadData("Введите количество строк ");
// int column = ReadData("Введите количество столбцов ");
// int coorR = ReadData("Введите номер строки искомого числа ");
// int coorC = ReadData("Введите номер столбца искомого числа ");
// int max = 20;//к-во чисел фибоначчи
// string fibonacci = FibNum(max);
// int[,] arr2D = Fill2DArray(row, column, fibonacci);
// int elem = SearchElem(arr2D,coorR,coorC);
// Print2DArrayColor(arr2D, coorR, coorC);
// PrintData(elem,coorR, coorC);
