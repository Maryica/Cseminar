

// Напишите программу, которая принимает на 
// вход два числа и проверяет, является ли одно 
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

int number_1 = int.Parse(Console.ReadLine()!);
int number_2 = int.Parse(Console.ReadLine()!);
if (number_1 * number_1 == number_2 || number_2 * number_2 == number_1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}