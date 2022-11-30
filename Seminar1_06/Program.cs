//является ли число чётным (делится ли оно на два без остатка)


//считываем данные с консоли
string? Num1Line = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (Num1Line != null)
{
    //Парсим введенное число
    int inputNumb = int.Parse(Num1Line);
    int remainder = inputNumb % 2;

    if (remainder == 0)
    {
        //Выводим данные в консоль
        Console.WriteLine(inputNumb +  " четное число");
    }
    else
    {
         //Выводим данные в консоль
        Console.WriteLine(inputNumb +  " нечетное число");   
    }  
}
