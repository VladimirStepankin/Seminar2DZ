/* Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа */

int number = ReadInt("Введите трехзначное число: ");
if (number < 0)
    number = - number;
if (number < 100 || number > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    int SecondNumber = (number % 100) /10;
    Console.Write(SecondNumber);
}
int ReadInt(string messadge)
{
    Console.Write(messadge);
    return Convert.ToInt32(Console.ReadLine());
}