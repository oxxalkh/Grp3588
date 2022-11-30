//какое число большее, а какое меньшее.

//считываем данные с консоли
string? Num1Line = Console.ReadLine();
string? Num2Line = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (Num1Line != null && Num2Line != null)
{
    //Парсим введенное число
    int num1 = int.Parse(Num1Line);
    int num2 = int.Parse(Num2Line);
 
    if (num1 > num2)
    {
        int max = num1;
        int min = num2;
        //Выводим данные в консоль
        Console.WriteLine("max = "+ max);
        Console.WriteLine("min = "+ min);

    }
    else
    {
        int max = num2;
        int min = num1;
        //выводим данные в консоль
        Console.WriteLine("max = "+ max);
        Console.WriteLine("min = "+ min);
    }  
}

//вариант 2
//не поняла как выполнить его для отрицатльных чисел, что нужно добавить?
//string? Num1Line = Console.ReadLine();
//string? Num2Line = Console.ReadLine();

//if (Num1Line != null && Num2Line != null)
//{
    //int num1 = int.Parse(Num1Line);
    //int num2 = int.Parse(Num2Line);
   
//int max = Math.Max(num1, num2);
//System.Console.WriteLine("max = " + max);
//}