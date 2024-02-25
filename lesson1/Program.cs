// Console.WriteLine("first code in c#");

// Console.WriteLine("write first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("write second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2 * num2)
// {
//     Console.WriteLine("yes");
// }
// else Console.WriteLine("no");

// using System;

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         // Введите свое решение ниже

//         if (firstNumber > secondNumber) {
//            // Console.WriteLine("больше, чем ");
//             Console.WriteLine("меньше, чем ");
//         } else if (firstNumber < secondNumber) {
//            // Console.WriteLine("меньше, чем ");
//             Console.WriteLine("больше, чем ");
//         } else {
//             Console.WriteLine("равно ");
//         }

//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2) {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 5;
//             secondNumber = 6;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }
// int[] arr = new int[5];

// arr[0] = 5;
// arr[1] = 7;
// arr[2] = 3;
// arr[3] = 8;
// arr[4] = 1;
// Console.WriteLine(arr[0]);
// Console.WriteLine(arr[1]);
// Console.WriteLine(arr[2]);
// Console.WriteLine(arr[3]);
// Console.WriteLine(arr[4]);
// Console.WriteLine(arr[5]);

// int [] arr2 = new int[5] {1,2,3,4,5};
// int [] arr3 = {1,2,3,4,5};

// int N = 10;

// int[] arr = new int[N];
// int i = 0;
// while(i<N)
// {
//     arr[i] = i + 1;
//     Console.WriteLine($"{arr[i]}");
//     i = i + 1;
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите число для проверки:");
//         int number = Convert.ToInt32(Console.ReadLine());

//         if (number % 7 == 0 && number % 23 == 0)
//         {
//             Console.WriteLine("Число кратно и 7, и 23.");
//         }
//         else
//         {
//             Console.WriteLine("Число не кратно одновременно 7 и 23.");
//         }
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите координаты точки (X и Y):");
//         Console.Write("X = ");
//         double x = Convert.ToDouble(Console.ReadLine());
//         Console.Write("Y = ");
//         double y = Convert.ToDouble(Console.ReadLine());

//         int quadrant;

//         if (x > 0 && y > 0)
//         {
//             quadrant = 1;
//         }
//         else if (x < 0 && y > 0)
//         {
//             quadrant = 2;
//         }
//         else if (x < 0 && y < 0)
//         {
//             quadrant = 3;
//         }
//         else
//         {
//             quadrant = 4;
//         }

//         Console.WriteLine($"Точка находится в {quadrant} координатной четверти.");
//     }
// }


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите целое число из отрезка [10, 99]:");
//         int number = Convert.ToInt32(Console.ReadLine());

//         int firstDigit = number / 10;
//         int secondDigit = number % 10;

//         int maxDigit;

//         if (firstDigit > secondDigit)
//         {
//             maxDigit = firstDigit;
//         }
//         else
//         {
//             maxDigit = secondDigit;
//         }

//         Console.WriteLine($"Наибольшая цифра числа {number} - {maxDigit}");
//     }
// }


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите натуральное число N:");
//         int number = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Цифры числа через запятую:");

//         string numberString = number.ToString();

//         Console.Write(numberString[0]);

//         for (int i = 1; i < numberString.Length; i++)
//         {
//             Console.Write($", {numberString[i]}");
//         }

//         Console.WriteLine();
//     }
// }


// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Подсчет количества элементов массива, попадающих в заданный диапазон
//     // numbers - массив, в котором ведется подсчет
//     // minRange - минимальная граница диапазона
//     // maxRange - максимальная граница диапазона
//     public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
//     {
//         //Введите сюда свое решение
//         int j = 0;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if ((numbers[i] >= minRange) & (numbers[i] <= maxRange))
//             {
//                 j++;
//             }
//          }
//         return j;
//     }

// public static void PrintResult(int[] array)
// {

//     //Введите сюда свое решение
//     //   UserInputToCompileForTest.CountItemsRange(array, 10, 90);
//     Console.WriteLine(UserInputToCompileForTest.CountItemsRange(array, 10, 90));
// }

// }


// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;


//         if (args.Length >= 1)
//         {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();

//             // Теперь arr содержит преобразованные в целые числа из командной строки

//         }
//         else
//         {
//             // Если аргументов на входе нет
//             array = new int[] { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 }; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }



// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Подсчет количества четных элементов массива
//     // numbers - массив, в котором ведется подсчет
//     public static int CountEvenItems(int[] numbers)
//     {
//         //Напишите свое решение здесь
//         int j = 0;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] % 2 == 0)
//             {
//                 j++;
//             }
//         }
//         return j;


//     }

//     public static void PrintResult(int[] array)
//     {
//         //Напишите свое решение здесь
//         Console.WriteLine(UserInputToCompileForTest.CountEvenItems(array));
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;


//         if (args.Length >= 1)
//         {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();

//             // Теперь arr содержит преобразованные в целые числа из командной строки

//         }
//         else
//         {
//             // Если аргументов на входе нет
//             array = new int[] { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 }; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }



// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Разница между максимальным и минимальным элементами массива

//     // Нахождение минимума массива
//     public static double FindMin(double[] numbers)
//     {
//         //Напишите свое решение здесь
//           double a = numbers[0];
//         for (int i = 1; i < numbers.Length; i++)
//         {
//             if (a > numbers[i])
//             {
//                 a = numbers[i];
//             }

//         }
//         return a;
//     }

//     // Нахождение максимума массива
//     public static double FindMax(double[] numbers)
//     {
//         //Напишите свое решение здесь
//         double a = numbers[0];
//         for (int i = 1; i < numbers.Length; i++)
//         {
//             if (a < numbers[i])
//             {
//                 a = numbers[i];
//             }

//         }
//         return a;
//     }



//     public static void PrintResult(double[] array)
//     {
//         //Напишите свое решение здесь
//         Console.WriteLine(UserInputToCompileForTest.FindMax(array) - UserInputToCompileForTest.FindMin(array));
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         double[] array;


//         if (args.Length >= 1)
//         {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(double.Parse)
//                                   .ToArray();

//             // Теперь arr содержит преобразованные в целые числа из командной строки

//         }
//         else
//         {
//             // Если аргументов на входе нет
//             array = new double[] { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 }; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }

// double CalculateFormula(int a, int b, int c, int d)
// {
//     double numenator = a *b;
//     double denumenator = c+d;
//     double result = numenator/denumenator;
//     return result;
// }
// double result = CalculateFormula(1,2,3,4);
// Console.WriteLine(result);

// void PrintSquares(int limit)
// {
//     int i = 1;
//     while (i <= limit)
//     {
//         Console.Write($"{i * i} ");
//         i++;
//     }
// }
// PrintSquares(5);
// PrintSquares(10);
// PrintSquares(15);


void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int[] array = { 1, 2, 3, 4, 5 };
ZeroEvenElements(array);
PrintArray(array);