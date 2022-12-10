//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}



bool PalindromTest(int number)
{
    bool result = false;
    
    if  ((number/10000 == number%10) && ((number/1000)%10 == (number/10)%10)) result = true;
    

    return result;
}


//Метод выводит данные пользователю
void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}


int numb = ReadData("Введите пятизначное число: ");

bool resultP = PalindromTest(numb);

if (numb > 9999 && numb < 100000)
{
    if (resultP)
    {
        PrintData("Это палиндром ", numb);
    }
    else
    {
        PrintData("Это не палиндром ", numb);
    }
}
else Console.WriteLine( numb + " Вы ввели не пятизначное число!");

