// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// using System;

// class Answer {
//     static void CheckIfDivisibleBySevenAndTwentyThree(int number1)
//     {
//         if (number1 % 7 == 0 && number1 % 23 == 0)
//         {
//             Console.WriteLine("Число кратно 7 и 23");
//         }
//         else
//         {
//             Console.WriteLine("Число не кратно одновременно 7 и 23");
//         }
//     }

//     static public void Main(string[] args) {
//         int number1;

//         if (args.Length >= 1) {
//             number1 = int.Parse(args[0]);
//         } else {
//             number1 = 162; // кратно 7 и 23
//         }

//         CheckIfDivisibleBySevenAndTwentyThree(number1);
//     }
// }

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// using System;

// class Answer {
//     static void FindQuadrant(int x, int y)
//     {
//         if (x > 0 && y > 0)
//         {
//             Console.WriteLine("Точка находится в первой координатной четверти");
//         }
//         else if (x < 0 && y > 0)
//         {
//             Console.WriteLine("Точка находится во второй координатной четверти");
//         }
//         else if (x < 0 && y < 0)
//         {
//             Console.WriteLine("Точка находится в третьей координатной четверти");
//         }
//         else if (x > 0 && y < 0)
//         {
//             Console.WriteLine("Точка находится в четвёртой координатной четверти");
//         }
//         else
//         {
//             Console.WriteLine("Точка лежит на одной из осей координат");
//         }
//     }

//     static public void Main(string[] args) {
//         int x, y;

//         if (args.Length >= 2) {
//             x = int.Parse(args[0]);
//             y = int.Parse(args[1]);
//         } else {
//             x = 2;
//             y = 2;
//         }

//         if (x != 0 && y != 0) {
//             FindQuadrant(x, y);
//         } else {
//             Console.WriteLine("Координаты точки не могут быть нулевыми.");
//         }
//     }
// }

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

// using System;

// class Answer {
//     static void FindMaxDigit(int number)
//     {
//         int maxDigit = 0;
//         while (number > 0)
//         {
//             int digit = number % 10;
//             if (digit > maxDigit)
//             {
//                 maxDigit = digit;
//             }
//             number = number / 10;
//         }
//         Console.WriteLine($"Наибольшая цифра в числе: {maxDigit}");
//     }

//     static public void Main(string[] args) {
//         int inputNumber;

//         if (args.Length >= 1) {
//             inputNumber = int.Parse(args[0]);
//         } else {
//             inputNumber = 12;
//         }

//         if (inputNumber >= 10 && inputNumber <= 99) {
//             FindMaxDigit(inputNumber);
//         } else {
//             Console.WriteLine("Число должно быть из отрезка [10, 99]");
//         }
//     }
// }

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

using System;

class Answer {
    static void PrintDigits(int number)
    {
        string digits = "";
        while (number > 0)
        {
            int digit = number % 10;
            digits = digit + ", " + digits;
            number = number / 10;
        }
        digits = digits.Remove(digits.Length - 2);
        Console.WriteLine($"Цифры числа через запятую: {digits}");
    }

    static public void Main(string[] args) {
        int inputNumber;

        if (args.Length >= 1) {
            inputNumber = int.Parse(args[0]);
        } else {
            inputNumber = 197452;
        }

        if (inputNumber > 0) {
            PrintDigits(inputNumber);
        } else {
            Console.WriteLine("Число должно быть натуральным");
        }
    }
}
