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

int N = 10;

int[] arr = new int[N];
int i = 0;
while(i<N)
{
    arr[i] = i + 1;
    Console.WriteLine($"{arr[i]}");
    i = i + 1;
}