// Напишите программу, которая будет
// принимать на вход два числа и выводить,
// является ли второе число кратным
// первому. Если второе число некратно
// первому, то программа выводит о статок
// от деления

int firstNumber = int.Parse(Console.ReadLine()??"0");

int secondNumber = int.Parse(Console.ReadLine()??"0");

int resultNumber = secondNumber%firstNumber;

if (resultNumber == 0)
{
    System.Console.WriteLine("Число делится без остатка");

}
else
{
    System.Console.WriteLine("Второе число не кратно первому. Остаток от деления " + (resultNumber));
}
