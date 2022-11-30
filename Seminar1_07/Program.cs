//программа, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа

//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputLine!=null)
{
int inputNumber = int.Parse(inputLine);

int lastDigit = inputNumber % 10;


Console.WriteLine(lastDigit);
}
