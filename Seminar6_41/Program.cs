//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int count = ReadData("ВВедите количество чисел: ");
int result = CountPositivNumb(count);
PrintData($"Количество позитивных чисел {result}: ");


//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}
//метод подсчета позитивных чисел
int CountPositivNumb(int N)
{
    int res=0;
    while (N>0)
    {
        if((ReadData("Введите число:"))>0) res++;
        N=N-1;
    }
    return res;
}


// вариант с массивом
// Console.Write("Введите числа через пробел: ");

// int[] arrNum = Array.ConvertAll((Console.ReadLine()??" ").Split(), int.Parse);
// int count = 0;
 
// for (int i = 0; i < arrNum.Length; i++)
// {
//     if (arrNum[i] > 0)
//     {
//         count++;
//     }
// }
 
// Console.WriteLine($"Количество позитивных чисел: {count}");


//________________________


//со звездочкой не делала, только разбиралась с readkey

// ConsoleKeyInfo keypress;
// Console.WriteLine("Ввести несколько символов, далее нажать '0' ");
// int count = 0;
// do
// { 
//         keypress = Console.ReadKey();
//         if (keypress.Key >= ConsoleKey.D0 && keypress.Key <= ConsoleKey.D9)
//         {
//                 if (keypress.Key == ConsoleKey.D0)
//                 {    
//                         System.Console.WriteLine(" ");
//                         break;
//                 }    
//                 else
//                 {
//                         count++;
//                         System.Console.WriteLine(" ");
//                 }
//                 Console.WriteLine($"Hажатий клавиш: {count}");
//         }
// } 
// while (keypress.KeyChar != '0');

