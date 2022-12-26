// Задача 62: Заполните спирально массив 4 на 4.

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

int size = 4;
SpiralMatrix(size);

void SpiralMatrix(int N)
{
    int n = 0;
    int[,] matrix = new int[N, N];

    int x0 = 0;
    int xn = N - 1;
    int y0 = 0;
    int yn = N - 1;

    while (n < N * N)
    {
        for (int x = x0; x <= xn; x++)
        {
            matrix[y0, x] = ++n;
        }
        y0++;

        for (int y = y0; y <= yn; y++)
        {
            matrix[y, xn] = ++n;
        }
        xn--;

        for (int x = xn; x >= x0; x--)
        {
            matrix[yn, x] = ++n;
        }
        yn--;

        for (int y = yn; y >= y0; y--)
        {
            matrix[y, x0] = ++n;
        }
        x0++;
    }

    for (int y = 0; y < N; y++)
    {
        for (int x = 0; x < N; x++)
        {
            Console.ForegroundColor = col[matrix[y, x] % 15];
            Console.Write(matrix[y, x] + "   ".Substring(matrix[y, x].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }

}


