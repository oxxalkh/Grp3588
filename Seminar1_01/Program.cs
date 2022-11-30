//Проверить является ли первое число квадратом второго

string? Num1Line = Console.ReadLine();
string? Num2Line = Console.ReadLine();



if (Num1Line != null && Num2Line != null)
{
    int num1 = int.Parse(Num1Line);
    int num2 = int.Parse(Num2Line);
   
    if (num2 * num2 == num1)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
    
}
