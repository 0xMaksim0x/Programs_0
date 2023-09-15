//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите трёхзначное число: ");
string number = Console.ReadLine();
int num = int.Parse(number);

if (num < 100 || num > 99999) 
{
    Console.Write($"Третьего числа нет ");
}
else
{
    int num1 = (num % 100) % 10;
    Console.Write($"Вторая цифра числа {num1}");
}
 if (num > 1000 || num > 99999)
{
    int num1 = (num % 1000) / 100;
    Console.Write($"Вторая цифра числа {num1}");
}