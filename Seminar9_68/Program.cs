// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int funcAkkerman = AkkFunc(m, n);
PrintResult(funcAkkerman);


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
    Console.WriteLine($"Функция Аккермана = {funcAkkerman} ");
}

//функция Аккермана
int AkkFunc(int m, int n)
{
  if (m == 0) return n + 1;
  else if ((m != 0) && (n == 0)) return AkkFunc(m - 1, 1);
  else return AkkFunc(m - 1, AkkFunc(m, n - 1));
}

