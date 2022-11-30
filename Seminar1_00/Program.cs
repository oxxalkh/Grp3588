//Произведение чисел
//string? Num1Line = Console.ReadLine();
//string? Num2Line = Console.ReadLine();
//if(Num1Line!=null&&Num2Line!=null)
//{
//    int num1 = int.Parse(Num1Line);
//    int num2 = int.Parse(Num2Line);

//    int outResult = num1*num2;
//    System.Console.WriteLine(outResult);
//}

//Нахождение квадрата числа
//считываем данные с консоли
string? inputLine = Console.ReadLine();
//проверяем чтобы данные не были пустыми
if(inputLine!=null)
{
    //парсим введенное число
    int inputNumber = int.Parse(inputLine);
    //находим квадрат числа
    int outNumber = inputNumber*inputNumber;
    //второй вариант
    // int outNumber = (int)Match.Pow(inputNumber, 2);
    //выводим данные в консоль
    System.Console.WriteLine(outNumber);
}

//третии вариант

//считываем данные с консоли
//string? inputLine = Console.ReadLine();
//проверяем чтобы данные не были пустыми
//if(inputLine!=null)
//{
    //System.Console.WriteLine(Math.Pow(inputLine), 2));
//}    
