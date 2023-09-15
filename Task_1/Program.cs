//Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает вторую
//цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


Console.Write("Введите трёхзначное число: ");
string number = Console.ReadLine();
int num = int.Parse(number);

if (num < 100 || num > 999)
{
    Console.Write($"Введёное число некорректно {num}");
}
else
{
    int num2 = (num % 100) / 10;
    Console.Write($"Вторая цифра числа {num2}");
}
