// Напишите программу, которая выводит
// случайное трёхзначное число и удаляет
// вторую цифру этого числа.


System.Random numberSint = new System.Random();

int number = numberSint.Next(100,1000);
Console.WriteLine(number);

int firstNumber = number/100;

int secondNumber = number%10;

int resultNumber = firstNumber * 10 + secondNumber;

//2 вариант
//int resultNumber = number/100 * 10 + number%10; можно им заменить переменные fn, sn

System.Console.WriteLine(resultNumber);

//3 вариант
//System.Console.WriteLine(number/100 * 10 + number%10); можно им заменить переменные fn, sn, rn и сразу вывести в консоль ответ


//4 вариант универсальный для любых чисел

// System.Random random = new System.Random(); 

// int randomNumber = random.Next(100,1000); рандом числа из диапвзона

// Console.WriteLine("число: " + randomNumber); 

// string value = randomNumber.ToString(); вывод числа в строку

// char[] numberArray = value.ToCharArray(); преобразование в массив

// Console.WriteLine(numberArray[0] +"" + numberArray[2]); вывод ячеек массива