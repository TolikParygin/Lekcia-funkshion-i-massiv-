//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.Clear();
int nomberA = new Random ().Next(10,99);
Console.WriteLine(nomberA);
int a = nomberA/10;
int b = nomberA%10;
    if (a>=b) Console.Write(a);
    else Console.Write(b);