//Напишите программу, которая по заданному номеру четверти, показывает диапазон 
//возможных координат точек в этой четверти (x и y).


int quat = ReadData("Введите номер четверти");
PrintAnswer(quat);
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}



void PrintAnswer(int number)
{
    if (number > 0 && number < 5)

{
    if (number == 1) Console.WriteLine("x > 0, y > 0");
    if (number == 2) Console.WriteLine("x > 0, y < 0");
    if (number == 3) Console.WriteLine("x < 0, y < 0");
    if (number == 4) Console.WriteLine("x < 0, y > 0");
   
}
 else Console.WriteLine("Вы ввели не номер четверти!");
}
    