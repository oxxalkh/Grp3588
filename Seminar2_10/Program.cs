 //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа


// Вариант 1
// int number = int.Parse(Console.ReadLine()??"0"); //вводим число

// if (number>99 && number<1000) //условие трехзначности

// {

//     string value = number.ToString();    //вывод числа в строку

//     char[] numberArray = value.ToCharArray();  //преобразование в массив

//     Console.WriteLine(numberArray[1]);  //вывод ячейки массива
// }
// else
// {
//     System.Console.WriteLine("это не трехзначное число"); //выводим результат
// }


// Вариант 2

int number = int.Parse(Console.ReadLine()??"0"); //вводим число
if (number>99 && number<1000)//условие трехзначности
{
    int result = number/10 %10;//ищем второе число
    System.Console.WriteLine(result); //выводим результат
}
else
{
   System.Console.WriteLine("это не трехзначное число"); //выводим результат
}
