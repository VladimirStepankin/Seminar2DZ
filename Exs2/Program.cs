/*Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет*/
int number = ReadInt("Введите число: ");
if (number < 0)
    number = - number;
if (number < 100 )
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    while (number > 999)
       {
        number = number/10;
       } 
    int SecondNumber = number % 10;
    Console.Write(SecondNumber);
}
int ReadInt(string messadge)
{
    Console.Write(messadge);
    return Convert.ToInt32(Console.ReadLine());
}