// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

// Вариант1

// int number = int.Parse(Console.ReadLine()??"0");

// if (number>99)

// {

// string value = number.ToString();    //перевод числа в строку

// char[] numberArray = value.ToCharArray();  //преобразование в массив

// Console.WriteLine(numberArray[2]);  //вывод ячеек массива
// }
// else
// {
//     System.Console.WriteLine("третьей цифры нет");
// }


// Вариант 2

//int number = int.Parse(Console.ReadLine()??"0");
// if (number>99) 
// {
//     Char[]digits = number.ToStray.ToCharArray(); //перевод числа в строку, преобразование в массив
//     System.Console.WriteLine(digits[2]); //вывод результата
// }

// else
// {
//     System.Console.WriteLine("третьей цифры нет"); //вывод результата
// }




// Вариант 3

// int number = int.Parse(Console.ReadLine()??"0");

// int num = number;

// int lengthNumb = 0;
// while(num > 0) //ищем количество цифр введеного числа
//   {
//    lengthNumb++;
//    num /= 10;
//   }


// while(lengthNumb > 3 ) //приводим число к трехзначному виду
//   {
//    lengthNumb = lengthNumb -1 ;
//     number/= 10;
//   }

// int result = number % 10;// находим путем деления с остатком третье число
// System.Console.WriteLine("Третья цифра заданного числа " + result );

// Вариант 4

int number = int.Parse(Console.ReadLine()??"0");

double lengthNumb = Math.Log10(number); //ищем количество цифр введеного числа
  


while(lengthNumb > 3 ) //приводим число к трехзначному виду
  {
   lengthNumb = lengthNumb -1 ;
    number/= 10;
  }

int result = number % 10;// находим путем деления с остатком третье число
System.Console.WriteLine("Третья цифра заданного числа " + result );



// //  определить длину числа еще вариант 
// int number = int.Parse(Console.ReadLine()??"0");
// int lenthNumb = 1 ;

//     if (number <= 10) 
//         { 
//         lenthNumb = 1;
//         }
//     else
//         while(number > 10 ) 
//         {
//         number /= 10;
//         ++lenthNumb;
//         }
     
//      System.Console.WriteLine("Количество цифр введенного числа " + lenthNumb);

