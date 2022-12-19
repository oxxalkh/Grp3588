// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.


//Метод, считывающий данные, введенные пользователем
double ReadData(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToDouble(Console.ReadLine() ?? "0");
}
//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}




double k1 = ReadData("Введите k1");
double b1 = ReadData("Введите b1");
double k2 = ReadData("Введите k2");
double b2 = ReadData("Введите b2");

 //вычисляем координаты 

if ((k1 == k2) && (b1 == b2))
 {
 PrintData("Прямые совпадают");
 }
else if (k1==k2)
{
 PrintData("Прямые параллельны");
}
else
{
 double x = (b2 - b1) / (k1 - k2);
 double y = k1 * x + b1;
 PrintData($"Пересечение в точке: ({x};{y})");
}





//____________________________

// //Метод, считывающий данные, введенные пользователем
// double ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return Convert.ToDouble(Console.ReadLine() ?? "0");
// }
// //Метод, выводящий на печать данные пользователю
// void PrintData(string res)
// {
//     Console.WriteLine(res);
// }


// double k1 = ReadData("Введите k1");
// double b1 = ReadData("Введите b1");
// double k2 = ReadData("Введите k2");
// double b2 = ReadData("Введите b2");
// double k3 = ReadData("Введите k3");
// double b3 = ReadData("Введите b3");

// //вычисляем координаты 

// double x1 = (b2 - b1) / (k1 - k2);
// double y1 = k1 * x1 + b1;

// double x2 = (b3 - b1) / (k1 - k3);
// double y2 = k3 * x2 + b3;

// double x3 = (b2 - b3) / (k3 - k2);
// double y3 = k2 * x3 + b2;

// double Sq = 0.5 * Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1));//вычисляем площадь
// PrintData($"Площадь треугольника равна {Sq} ");




