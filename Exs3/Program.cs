/*Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным*/ 
 int number = ReadInt("Введите цифру, обозначающую день недели: ");
if (number < 1 || number > 7)
{
    Console.WriteLine("Введена неверная цифра");
    
}
else
{
    if (number == 6 || number == 7 )
    {
        Console.WriteLine("Да");
    }
    else
    {
    Console.Write("Нет");
    }
}
int ReadInt(string messadge)
{
    Console.Write(messadge);
    return Convert.ToInt32(Console.ReadLine());
}