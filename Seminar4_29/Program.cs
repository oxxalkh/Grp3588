//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int arrLen = ReadData("Введите длину массива.");
int arrFirst = ReadData("Введите минимальное значение ячейки массива.");
int arrSecond = ReadData("Введите максимальное значение ячейки массива.");

int[] arr = GenArr(arrLen,arrFirst, arrSecond);

PrintData("Сгененрированный массив:",arr);

//методы
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArr(arr);
}

int[] GenArr(int num, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue+1);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

//____________________
// Variant*

// string name = ReadData("Введите имена через запятую.");

// string nameR = NameRandom(name);

// PrintData("Вывести крайнего:", nameR);

// string ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return Console.ReadLine() ?? "0";
// }

// string NameRandom(string text)
// {
//     string[] words = text.Split(new char[] { ' ',',' }, StringSplitOptions.RemoveEmptyEntries);
   
//     var ind = new Random().Next(words.Length);
//     System.Console.WriteLine(words[ind]);
     
//     return words[ind];
// }
// void PrintData(string msg, string res)
// {
//     Console.WriteLine(msg + res);
   
// }

