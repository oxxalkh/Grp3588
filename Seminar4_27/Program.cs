//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


        int number = ReadData("Введите число:");

        DateTime d1 = DateTime.Now;
        int result1 = SummDigitSimple(number);
        Console.WriteLine(DateTime.Now - d1);

        DateTime d2 = DateTime.Now;
        int result2 = SummDigitsArray(number);
        Console.WriteLine(DateTime.Now - d2);

        PrintData("Сумма цифр в числе равна " + result1);
        PrintData("Сумма цифр в числе равна " + result2);


//методы

        int ReadData(string msg) //вводим число
        {
            Console.WriteLine(msg);
            return int.Parse(Console.ReadLine() ?? "0");
        }

        void PrintData(string res)//выводим результат
        {
            Console.WriteLine(res);
        }

        int SummDigitSimple(int num) //вычисление суммы числа
        {
            int result = 0;
            while (num > 0)
            {
                result += num % 10;
                num = num / 10;
            }
            return result;
        }


        int SummDigitsArray(int numb) //вычисление суммы числа через массив
        {
            char[] numbArray = numb.ToString().ToCharArray();    //вывод числа в строку, //преобразование в массив
            // int sum = 0;
            // foreach (int item in numbArray) 
            // {
            // sum += (item - '0'); //переводим в int и вычисляем сумму
            // }
            int length = lengthString(numb);
            int[] array = new int[numbArray.Length];
            for (int i = 0; i < numbArray.Length; i++)
            {
                array[i] = Convert.ToInt32(numbArray[i].ToString());
            }
            int sum = 0;
            foreach (int item in array) 
            {
            sum += item ; // вычисляем сумму
            }

            return sum;
        }

         int lengthString(int num)
            {
                int lengthNumb = num.ToString().Length;
                return lengthNumb;
            }
   

