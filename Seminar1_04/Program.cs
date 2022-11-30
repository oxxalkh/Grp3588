//вывести максимальное из 3 чисел

//считываем данные с консоли
string? Num1Line = Console.ReadLine();
string? Num2Line = Console.ReadLine();
string? Num3Line = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (Num1Line != null && Num2Line != null && Num3Line != null)
{
    //Парсим введенное число
    int num1 = int.Parse(Num1Line);
    int num2 = int.Parse(Num2Line);
    int num3 = int.Parse(Num3Line);
    
    if (num1 > num2)
    {
        if (num1 > num3)
        {
            //выводим данные на консоль
            System.Console.WriteLine("max = " + num1);
        }
        else
        {
            //выводим данные на консоль
            System.Console.WriteLine("max = " + num3);
        }
    }
    else 
    {
        if (num2 > num3)
        {
            //выводим данные на консоль
            System.Console.WriteLine("max = " + num2);
        }
        else
        {
            //выводим данные на консоль
            System.Console.WriteLine("max = " + num3);
        }
          
    }  
}
