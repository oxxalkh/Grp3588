//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = GenArray(10, 100, 999); //генерируем массив
Print1DArr(array); //печатаем массив
BubbleSort(array);//сортируем по возрастанию
Print1DArr(array);//выводим отсортированный массив
int result = CountEven(array);//подсчитываем четные числа в массиве
PrintData("Kоличество чётных чисел в массиве: " + result); //выводим результат


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
int CountEven(int[]arr)//метод подсчитывания четных чисел
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (EvenTest(array[i]))
        {
        res++;
        }

        // if (array[i]%2==0)
        // {
        //     res++;
        // }
    }
    return res;
    
}

bool EvenTest(int A)//тест на четность
        {
            return (A%2==0);
        }

void BubbleSort(int[] inArray)//метод сортировки массива пузырьком по возрастанию
{
    for (int i = 0; i < inArray.Length; i++)
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] > inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
}        