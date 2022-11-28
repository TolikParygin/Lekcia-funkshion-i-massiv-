//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
Console.Clear();
int number_1 = new Random ().Next(100,1000);
int nomber_2 = (number_1/100)*10 + number_1 % 10;
Console.WriteLine (number_1 + " -> " + nomber_2);