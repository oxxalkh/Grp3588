// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
using System.Collections.Generic;

int x = ReadData("Введите измерение массива x : ");
int y = ReadData("Введите измерение массива y : ");
int z = ReadData("Введите измерение массива z : ");

List <int> num = new List <int>();
    for (int i=0; i < 90; i++)
    {
        num.Add(10+i);
    }

int[,,] array3D = Fill3DArray(x,y,z);
PrintArray(array3D);   

//генерирование уникальных чисел
int GenNumb(List <int> num)
{
int index = new Random().Next(0, num.Count);
int outNum = num[index];
num.RemoveAt(index);
return outNum;
}    

// печать массива и координат
void PrintArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $" {array3D[i,j,k]} (x{i}, y{j}, z{k}) ; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

//трехмерный массив с неповторяющимися двузначными числами
int [,,] Fill3DArray(int x, int y, int z)
{
int[,,] array3D = new int[x, y, z];
int[] list = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];

for (int i = 0; i < list.GetLength(0); i++)
{
    int number = GenNumb(num);
    list[i] = number;   
    int count = 0;
  for (int a = 0; a < array3D.GetLength(0); a++)
  {
    
    for (int b = 0; b < array3D.GetLength(1); b++)
    {
      for (int c = 0; c < array3D.GetLength(2); c++)
      {
        array3D[a, b, c] = list[count];
        count++;
      }
    }
  } 
}
  return array3D;
}

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// // Универсальный метод генерации и заполнения трехмерного массива
// int[,,] Fill3DArray(int x, int y, int z)
// {
//     System.Random rand = new System.Random();
//     int[,,] array3D = new int[x,y,z];

//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//             array3D[i, j, k] = rand.Next(10, 100);
//             }
//         }
//     }
//     return array3D;
// }
