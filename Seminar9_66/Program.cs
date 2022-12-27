// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int sum = RecSum(m,n);
PrintResult(sum);
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(int res)
{
    Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {res}");
}

int RecSum(int M, int N)
{
    int outRes = 0;
    if (M >= N) return N;
     outRes = M + RecMN(M + 1, N);
    return outRes;
}
