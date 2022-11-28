//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4 ;16, 4 -> кратно
Console.Clear();
int number_1 = int.Parse(Console.ReadLine());
int number_2 = int.Parse(Console.ReadLine());
if (number_1 % number_2 == 0)
{
    Console.WriteLine(" ->  кратно");
}
else
{
    int number_3 = number_1 % number_2;
    Console.WriteLine(" -> не кратно, остаток " + number_3);
}
