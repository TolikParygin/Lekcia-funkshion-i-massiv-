// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
Console.Clear();
Console.WriteLine("Введите два числа: ");
int firstnumber = int.Parse(Console.ReadLine());
int secondnumber = int.Parse(Console.ReadLine());
if (firstnumber * firstnumber == secondnumber || secondnumber * secondnumber == firstnumber)
{
    Console.Write($"{firstnumber}, {secondnumber} -> да");
}
else
{
    Console.Write ($" {firstnumber}, {secondnumber} -> нет");
}