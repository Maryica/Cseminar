// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int firstValue = number / 100;
int thirdValue = number % 10;
int newNumber = firstValue * 10 + thirdValue;
Console.WriteLine(newNumber);




