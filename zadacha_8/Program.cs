// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.Clear();
int Figure(int N)
{
    int i = 0;
    for (i = 0; N != 0; i++)
    {
        N = N / 10;
    }
    return i;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write(number + " -> " + Figure(number));