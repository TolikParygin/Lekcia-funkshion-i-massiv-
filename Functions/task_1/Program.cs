Console.Clear();
int DataEnteryXY(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void FindQuandrant(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("это первыйи квадрант");
    if (x < 0 && y > 0) Console.WriteLine("это второй квадрант");
    if (x < 0 && y < 0) Console.WriteLine("это третий квадрант");
    if (x > 0 && y < 0) Console.WriteLine("это четвертый квадрант");
}
int x = DataEnteryXY("Введите координаты x: ");
Console.WriteLine(x);
int y = DataEnteryXY("Введите координаты y: ");
Console.WriteLine(y);
FindQuandrant(x, y);