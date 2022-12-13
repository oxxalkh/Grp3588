//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int numberA = ReadData("Введите число А:");
int numberB = ReadData("Введите число B:");
int result = Pow(numberA, numberB);
PrintData("Число A в натуральной степени B равно ", result);

//запрос данных у пользователя
int ReadData(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine() ?? "0");
        }


 // Метод вывода результата
 void PrintData(string msg, int rslt)
        {
            Console.WriteLine(msg + rslt);
        }

//метод вычисления числа в степени
        int Pow(int a, int b)
        {

            double resD = 1;
            resD = Math.Pow(a,b);
            int res = (int)resD;
            //res = 1
            // for (int i = 1; i <= b; i++)
            // {
            //     res = a * res;
            // }
            return res;
        }



// Variant*


// //запрос данных у пользователя
// int numberA = ReadData("Введите число А:");
// int numberB = ReadData("Введите число B:");


// int ReadData(string msg)
//         {
//             Console.Write(msg);
//             return int.Parse(Console.ReadLine() ?? "0");
//         }

// //запрос данных у пользователя
// Console.Write("Введите операцию: ");
//     string operation = Console.ReadLine()??"0";
//     var ops = new Dictionary<string, Func<int, int, int>> //создаем библиотеку
//             {
//                 {"+", (x, y) => x + y},//заполняем
//                 {"-", (x, y) => x - y},
//                 {"*", (x, y) => x*y},
//                 {"/", (x, y) => x/y}
//             };
//             if (!ops.ContainsKey(operation))
//             {
//                 Console.WriteLine("Не известная операция.");
//                 return;
//             }
//  //вычисляем и выводим результат 
// Console.WriteLine("{0} {1} {2} = {3}", numberA, operation, numberB, ops[operation](numberA, numberB));

//int дает не совсем корректный результат если a < b
//запрос данных у пользователя
// double numberA = ReadData("Введите число А:");
// double numberB = ReadData("Введите число B:");


// double ReadData(string msg)
//         {
//             Console.Write(msg);
//             return double.Parse(Console.ReadLine() ?? "0");
//         }

// //запрос данных у пользователя
// Console.Write("Введите операцию: ");
//     string operation = Console.ReadLine()??"0";
//     var ops = new Dictionary<string, Func<double, double, double>> //создаем библиотеку
//             {
//                 {"+", (x, y) => x + y},//заполняем
//                 {"-", (x, y) => x - y},
//                 {"*", (x, y) => x*y},
//                 {"/", (x, y) => x/y}
//             };
//             if (!ops.ContainsKey(operation))
//             {
//                 Console.WriteLine("Не известная операция.");
//                 return;
//             }
//  //вычисляем и выводим результат 
// Console.WriteLine("{0} {1} {2} = {3}", numberA, operation, numberB, ops[operation](numberA, numberB));


// немного другой вариант вывода данных

// //запрос данных у пользователя
// double numberA = ReadData("Введите число А:");
// double numberB = ReadData("Введите число B:");


// double ReadData(string msg)
//         {
//             Console.Write(msg);
//             return double.Parse(Console.ReadLine() ?? "0");
//         }

// //запрос данных у пользователя
// Console.Write("Введите операцию: ");
//     string operation = Console.ReadLine()??"0";
//     var ops = new Dictionary<string, Func<double, double, double>> //создаем библиотеку
//             {
//                 {"+", (x, y) => x + y},//заполняем
//                 {"-", (x, y) => x - y},
//                 {"*", (x, y) => x*y},
//                 {"/", (x, y) => x/y}
//             };
//             if (!ops.ContainsKey(operation))
//             {
//                 Console.WriteLine("Не известная операция.");
//                 return;
//             }
//  //вычисляем и выводим результат 
// double result = ops[operation](numberA, numberB);

// Console.WriteLine($"{numberA} {operation} {numberB} = {result}");