// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
int Multiplication(int N)
{
    int result = 1;
    for (int i = 1; i <= N; i++)
    {
        result = result * i;
    }
    return result;
}


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write(number + " -> " + Multiplication(number));