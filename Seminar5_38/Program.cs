//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


// double[] array = GenArray(10,5,100);
// PrintArray(array);
// Console.WriteLine();
// MinMax(array);

// void PrintData(string msg, double res )//метод вывода на печать результата
// {

//     Console.WriteLine(msg+res);
// }


// double[] GenArray(int len , int minValue, int maxValue) //генерируем массив
// {
//     Random rnd = new Random();
//     double[] outArray = new double[len];
//     for (int i = 0; i < len; i++)
//     {
//         outArray[i] = new Random().Next(minValue, maxValue)/10.0;
//     }
//     return outArray;
// }

// //Метод генерации массива
// double[] GenArray(int len)
// {
//     double[] arr = new double[len];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(-100, 100) + new Random().NextDouble();
//     }
//     return arr;
// }

// void PrintArray(double[] arr) //выводим на печать
// {
//     Console.Write("[");
//     for ( int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + " , ");
//     }
//     Console.Write(arr[arr.Length - 1] + "]");
// }

// void MinMax(double[] array)//Метод поиска min и мах
// {
//     double min = double.MaxValue;
//     double max = double.MinValue;
//     for (int i = 0; i < array.Length; i++)
//     {
//        if (array[i]>max) max = array[i];
//        if (array[i]<min) min = array[i];
//     }
//     System.Console.WriteLine(max);
//     System.Console.WriteLine(min);   
//     double res = 0;
//     res = max - min;
//    PrintData("Разница между максимальным и минимальным элементов массива: " , res); //выводим результат
// }
//___________________________________


//variant* не совсем поняла задачу, просто потренировалась в методах сортировки
    
int[] array = GenArray(10, 0, 20); //генерируем массив

Print1DArr(array); //печатаем массив
DateTime d1 = DateTime.Now;//скорость
int [] bubbleArr = BubbleSort(array);//сортируем по возрастанию
Console.WriteLine(DateTime.Now - d1);
Print1DArr(bubbleArr);//выводим отсортированный массив
DateTime d2 = DateTime.Now;//скорость
int [] countArr = CountSort(array);//сортируем по возрастанию
Console.WriteLine(DateTime.Now - d2);
Print1DArr(countArr);//выводим отсортированный массив
DateTime d3 = DateTime.Now;//скорость
int [] inseptArr = Insertion(array);//сортируем по возрастанию
Console.WriteLine(DateTime.Now - d3);
Print1DArr(inseptArr);//выводим отсортированный массив
int sortMin = inseptArr[0];
int sortMax = inseptArr[inseptArr.Length - 1];


PrintData($"Max {sortMax}, min {sortMin}"); //выводим результат


void PrintData(string msg) //метод вывода на печать результата
{
    Console.WriteLine( msg);
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



int[] BubbleSort(int[] inArray)//метод сортировки массива пузырьком по возрастанию
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
        return inArray;
}  

    
int[] CountSort(int[] array)// метод сортировки подсчетом
 {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
        var count = new int[max+1];
        for (var i = 0; i < array.Length; i++)
        {
            count[array[i]]++;
        }

        var index = 0;
        for (var i = 0; i < count.Length; i++)
        {
            for (var j = 0; j < count[i]; j++)
            {
                array[index] = i;
                index++;
            }
        }

        return array;
        
 }


int[] Insertion(int[] array) //метод сортировки вставками
        {
            
            for (int i = 1; i < array.Length; i++)
            {
                int num = array[i];
                int j = i - 1;

                
                while (j >= 0 && array[j] > num)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = num;
            }
            return array;
        }