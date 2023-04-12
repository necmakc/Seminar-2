// Задача 1: -------------------------------------------------------------------------------------------------------------
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// int SecondNumber(int num)
// {
//     num = num / 10 % 10;
//     return num;
// }

// bool Validate(int num)
// {
//     if (num > 99 && num < 1000)
//         return true;
//     else
//         return false;
// }

// Console.Write("Enter a three-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (Validate(number))
//     Console.WriteLine(SecondNumber(number));
// else
//     Console.WriteLine("Number is wrong");



// Задача 2: -------------------------------------------------------------------------------------------------------------
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// bool ValidateThird(int num)
// {
//     if (num > 100)
//         return true;
//     else
//         return false;
// }

// int ShowThirdNumber(int num)
// {
//     while (num > 999)
//     {
//         num /= 10;
//     }
//     return num % 10;
// }

// Console.Write("Enter a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (ValidateThird(number))
// {
//     int showThird = ShowThirdNumber(number);
//     Console.WriteLine(showThird);
// }
// else
//     Console.WriteLine("Third number is not");



// Задача 3: -------------------------------------------------------------------------------------------------------------
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// bool Weekend(int num)
// {
//     if (num > 5)
//         return true;
//     else return false;
// }

// bool Validate(int num)
// {
//     if (num >= 1 && num <= 7)
//         return true;
//     else
//         return false;
// }

// Console.Write("Enter the day of the week (number): ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (Validate(number))
// {
//     if (Weekend(number))
//         Console.WriteLine("Today is the weekend =))");
//     else
//         Console.WriteLine("Today is working day =(");
// }
// else
//     Console.Write("Number is wrong");