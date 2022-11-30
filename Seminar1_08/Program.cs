//показать все чётные числа от 1 до N.


//считываем данные с консоли
string? Num1Line = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (Num1Line != null)
{
    //Парсим введенное число
    int inputNumber = int.Parse(Num1Line);
    int startNumber = 2;

   //Выходное значение
   string outLine = string.Empty;

   while (startNumber<inputNumber)
   {
      outLine = outLine + startNumber + ", ";
      startNumber = startNumber+2;
   }
   int remainder = inputNumber % 2;
   if (remainder == 0)
   {
    outLine = outLine + inputNumber;
    // Выводим данные в консоль 
    Console.WriteLine(outLine);
    }
    else
    {
    // Выводим данные в консоль 
    Console.WriteLine(outLine);
    }
}
