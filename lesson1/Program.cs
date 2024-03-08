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


// void ZeroEvenElements(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             arr[i] = 0;
//         }
//     }
// }

// void PrintArray(int[] arr)
// {
//     foreach (int e in arr)
//     {
//         Console.Write($"{e} ");
//     }
// }

// int[] array = { 1, 2, 3, 4, 5 };
// ZeroEvenElements(array);
// PrintArray(array);

// using System.Globalization;

// int[,] matrix = new int[3, 5];

// Random rnd = new Random();
// for (int i =0; i < matrix.GetLength(0); i++)
// {
//     for (int j =0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = rnd.Next(1, 11);
//     }
// }

// for (int i =0; i < matrix.GetLength(0); i++)
// {
//     for (int j =0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите целые числа. Для завершения программы введите 'q' или введите число, сумма цифр которого чётная.");

//         while (true)
//         {
//             Console.Write("Введите число: ");
//             string input = Console.ReadLine();

//             if (input.ToLower() == "q")
//             {
//                 Console.WriteLine("Программа завершена.");
//                 break;
//             }

//             int number;
//             if (int.TryParse(input, out number))
//             {
//                 if (IsSumOfDigitsEven(number))
//                 {
//                     Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
//                     break;
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Ошибка: Введено некорректное значение. Повторите попытку.");
//             }
//         }
//     }

//     static bool IsSumOfDigitsEven(int number)
//     {
//         int sum = 0;
//         number = Math.Abs(number); 

//         while (number > 0)
//         {
//             sum += number % 10;
//             number /= 10;
//         }

//         return sum % 2 == 0;
//     }
// }


// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] array = GenerateRandomArray(10); 

//         Console.WriteLine("Массив случайных трёхзначных чисел:");
//         PrintArray(array);

//         int countEven = CountEvenNumbers(array); 

//         Console.WriteLine($"Количество чётных чисел в массиве: {countEven}");
//     }

//     static int[] GenerateRandomArray(int size)
//     {
//         Random rnd = new Random();
//         int[] array = new int[size];

//         for (int i = 0; i < size; i++)
//         {
//             array[i] = rnd.Next(100, 1000); 
//         }

//         return array;
//     }

//     static void PrintArray(int[] array)
//     {
//         foreach (int num in array)
//         {
//             Console.Write(num + " ");
//         }
//         Console.WriteLine();
//     }

//     static int CountEvenNumbers(int[] array)
//     {
//         int count = 0;

//         foreach (int num in array)
//         {
//             if (num % 2 == 0) 
//             {
//                 count++;
//             }
//         }

//         return count;
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] array = { 1, 2, 3, 4, 5 };

//         Console.WriteLine("Исходный массив:");
//         PrintArray(array);

//         ReverseArray(array);

//         Console.WriteLine("\n Перевёрнутый массив:");
//         PrintArray(array);
//     }

//     static void ReverseArray(int[] array)
//     {
//         int left = 0;
//         int right = array.Length - 1;

//         while (left < right)
//         {
//             int temp = array[left];
//             array[left] = array[right];
//             array[right] = temp;

//             left++;
//             right--;
//         }
//     }

//     static void PrintArray(int[] array)
//     {
//         foreach (int num in array)
//         {
//             Console.Write(num + " ");
//         }
//         Console.WriteLine();
//     }
// }


// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
// // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Поиск элемента по позициям
//     public static int FindElementByPosition(int[,] array, int x, int y)
//     {
//         //Напишите свое решение здесь
//         if (ValidatePosition(array, x, y))
//         {

//             return array[x - 1, y - 1];
//         }
//         else
//         {
//             return -1; // Возвращаем отрицательное значение для обозначения отсутствия элемента
//         }
//     }

// // Проверка позиций на вхождение в массив
//     public static bool ValidatePosition(int[,] numbers, int x, int y)
//     {
//         //Напишите свое решение здесь
//         return x >= 1 && x <= numbers.GetLength(0) && y >= 1 && y <= numbers.GetLength(1);
//     }

//     public static void PrintResult(int[,] numbers, int x, int y)
//     {
//        if (ValidatePosition(numbers, x, y))
//     {
//         // Находим и выводим элемент, если он существует
//         int element = FindElementByPosition(numbers, x, y);
//         Console.WriteLine($"Элемент по позиции ({x},{y}): {element}");
//     }
//     else
//     {
//         // Сообщаем, если позиции выходят за пределы массива
//         if (x < 1 || x > numbers.GetLength(0))
//         {
//             Console.WriteLine("Позиция по рядам выходит за пределы массива");
//         }
//         if (y < 1 || y > numbers.GetLength(1))
//         {
//             Console.WriteLine("Позиция по колонкам выходит за пределы массива");
//         }
//     }
//     }
// }


// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {   
//         int[,] array;

//         int x, y;

//         if (args.Length >= 3)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             array = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         array[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }

//             // Парсинг x и y из аргументов
//             if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
//             {
//                 // Теперь у вас есть двумерный массив "array" и координаты x и y
//                 UserInputToCompileForTest.PrintResult(array, x, y);
//             }
//             else
//             {
//                 Console.WriteLine("Error parsing x or y to an integer.");
//             }
//         }
//         else
//         {

//             // Если аргументов на входе нет, используем примерный массив
//             array = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             };
//             x = 2;
//             y = 2;

//             UserInputToCompileForTest.PrintResult(array, x, y);

//         }                
//     }
// }


// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Печать массива
//     public static void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write($"{array[i, j]}\t");
//             }
//             Console.WriteLine(" ");
//         }
//     }

//     // Обмен первой с последней строкой
//     public static int[,] SwapFirstLastRows(int[,] array)
//     {
//         int n = array.GetLength(0) - 1;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[0, j];
//             array[0, j] = array[n, j];
//             array[n, j] = temp;

//         }
//         return array;
//     }

//     // Обмен элементами массива
//     public static void SwapItems(int[,] array, int i)
//     {
//         //Напишите свое решение здесь
//           int n = array.GetLength(1);
//     for (int j = 0; j < n / 2; j++)
//     {
//         int temp = array[i, j];
//         array[i, j] = array[i, n - 1 - j];
//         array[i, n - 1 - j] = temp;
//     }
//     }

//     public static void PrintResult(int[,] numbers)
//     {
//         //Напишите свое решение здесь
//         SwapFirstLastRows(numbers);
//         PrintArray(numbers);

//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] numbers;

//         if (args.Length >= 1)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             numbers = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         numbers[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }
//         }
//         else
//         {
//             // Если аргументов на входе нет, используем примерный массив
//             numbers = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             };
//         }
//         UserInputToCompileForTest.PrintResult(numbers);
//     }
// }



// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
// // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Поиск элемента по позициям
// //     public static int FindElementByPosition(int[,] array, int x, int y)
// //     {
// //         //Напишите свое решение здесь
// //     }

// // // Проверка позиций на вхождение в массив
// //     public static bool ValidatePosition(int[,] array, int x, int y)
// //     {
// //         //Напишите свое решение здесь
// //     }

//     public static void PrintResult(int[,] numbers, int x, int y)
//     {
//         //Напишите свое решение здесь
//                 if (x > numbers.GetLength(0))
//         {
//                     Console.WriteLine("Позиция по рядам выходит за пределы массива");
//         }
//                 if (y > numbers.GetLength(1))
//         {
//                     Console.WriteLine("Позиция по колонкам выходит за пределы массива");
//         }
//         else
//         {
//                     Console.WriteLine(numbers[x-1,y-1]);
//         }
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {   
//         int[,] array;

//         int x, y;

//         if (args.Length >= 3)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             array = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         array[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }

//             // Парсинг x и y из аргументов
//             if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
//             {
//                 // Теперь у вас есть двумерный массив "array" и координаты x и y
//                 UserInputToCompileForTest.PrintResult(array, x, y);
//             }
//             else
//             {
//                 Console.WriteLine("Error parsing x or y to an integer.");
//             }
//         }
//         else
//         {

//             // Если аргументов на входе нет, используем примерный массив
//             array = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             };
//             x = 2;
//             y = 2;

//             UserInputToCompileForTest.PrintResult(array, x, y);

//         }                
//     }
// }



// using System;

// class UserInputToCompileForTest
// {
//     // Печать массива
//     public static void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write($"{array[i, j]}  ");
//             }
//             Console.WriteLine(" ");
//         }
//     }

//     // Обмен первой с последней строкой
//     public static int[,] SwapFirstLastRows(int[,] array)
//     {
//         int n = array.GetLength(0) - 1;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[0, j];
//             array[0, j] = array[n, j];
//             array[n, j] = temp;
//         }
//         return array;
//     }

//     // Обмен элементами массива
//     public static void SwapItems(int[,] array, int i)
//     {
//         int n = array.GetLength(1);
//         for (int j = 0; j < n / 2; j++)
//         {
//             int temp = array[i, j];
//             array[i, j] = array[i, n - 1 - j];
//             array[i, n - 1 - j] = temp;
//         }
//     }

//     public static void PrintResult(int[,] numbers)
//     {
//         SwapFirstLastRows(numbers);
//         PrintArray(numbers);
//     }
// }

// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] numbers;

//         if (args.Length >= 1)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             numbers = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         numbers[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }
//         }
//         else
//         {
//             // Если аргументов на входе нет, используем примерный массив
//             numbers = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             };
//         }
//         UserInputToCompileForTest.PrintResult(numbers);
//     }
// }



// using System;

// class Program
// {
//     static void PrintNumbersInRange(int m, int n)
//     {
//         if (m <= n)
//         {
//             Console.WriteLine(m);
//             PrintNumbersInRange(m + 1, n);
//         }
//     }

//     static void Main(string[] args)
//     {
//         Console.Write("Введите значение M: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение N: ");
//         int n = int.Parse(Console.ReadLine());

//         Console.WriteLine($"Натуральные числа в промежутке от {m} до {n}:");
//         PrintNumbersInRange(m, n);
//     }
// }



// using System;

// class Program
// {
//     static int Ackermann(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (n == 0)
//         {
//             return Ackermann(m - 1, 1);
//         }
//         else
//         {
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//         }
//     }

//     static void Main(string[] args)
//     {
//         Console.Write("Введите значение m: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение n: ");
//         int n = int.Parse(Console.ReadLine());

//         Console.WriteLine($"Результат функции Аккермана для m={m}, n={n}: {Ackermann(m, n)}");
//     }
// }

using System;

class Program
{
    static void PrintArrayReversed(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write(arr[index] + " ");
            PrintArrayReversed(arr, index - 1);
        }
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Элементы массива в обратном порядке:");
        PrintArrayReversed(array, array.Length - 1);
    }
}
