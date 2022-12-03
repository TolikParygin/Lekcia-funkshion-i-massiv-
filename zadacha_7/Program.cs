// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.Clear();
int Sum(int N)
{
    int result = 0;
    for (int count = 1; count <= N; count++)
    {
        result = result + count;
    }
    return result;    
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = Sum (number);
Console.Write(number + " -> " + result);