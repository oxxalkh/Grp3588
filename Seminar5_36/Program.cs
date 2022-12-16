//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = GenArray(10, 1, 20); //генерируем массив
Print1DArr(array); //печатаем массив
int result = SummOdd(array);//подсчитываем четные числа в массиве
PrintData("Сумма элементов, стоящих на нечётных позициях " + result); //выводим результат


void PrintData(string res) //метод вывода на печать результата
{
    Console.WriteLine(res);
}

int[] GenArray(int len, int minValue, int maxValue) //метод генерирования массива
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void Print1DArr(int[] arr)//метод вывода массива
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

int SummOdd(int[]arr)//метод суммирования чисел
{
    int res = 1;
    int i = 0;
    while ( i < arr.Length)
        {
        res+= arr[i];
        i=i+2;

        }
    return res;
}
    



