
// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

int number = int.Parse(Console.ReadLine()!);
int number2 = (-number - 1);
int count = 0;
while (count <= number * 2)
{
    count++;
    number2++;
    Console.WriteLine(number2);
}
