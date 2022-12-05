// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Вариант1
// string? inputLine = Console.ReadLine();//Считываем данные с консоли

// if (inputLine != null)//Проверяем, чтобы данные были не пустыми
// {
// int inputNumber = int.Parse(inputLine); //Парсим введенное число

    
//     if (inputNumber > 0 && inputNumber < 8)
//     {
//         if (inputNumber > 5)
//         {
//             System.Console.WriteLine("Выходной"); // Выводим данные в консоль 
//         }   
//         else
//         {
//             System.Console.WriteLine("Рабочий день");   // Выводим данные в консоль 
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("это не день недели");   // Выводим данные в консоль
//     }
// }

//Вариант 2
string? inputLine = Console.ReadLine();//Считываем данные с консоли

if (inputLine != null)//Проверяем, чтобы данные были не пустыми
{
int inputNumber = int.Parse(inputLine); //Парсим введенное число
    if (inputNumber > 0 && inputNumber < 8) //проверяем диапазон
    {
        string[] dayOfWeek = new string[7]; //Создаем массив с днями недели
       dayOfWeek[0] = "Рабочий день";
       dayOfWeek[1] = "Рабочий день";
       dayOfWeek[2] = "Рабочий день";
       dayOfWeek[3] = "Рабочий день";
       dayOfWeek[4] = "Рабочий день";
       dayOfWeek[5] = "Выходной день";
       dayOfWeek[6] = "Выходной день"; 
        
        string outDayOfWeek = dayOfWeek[inputNumber-1];//Находим название дня недели по введенному номеру
        System.Console.WriteLine(outDayOfWeek); // Выводим данные в консоль 
    }
    else
    {
       System.Console.WriteLine("это не день недели");   // Выводим данные в консоль 
    }
}      
