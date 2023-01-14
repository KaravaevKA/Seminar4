//Прием на вход число, выдает количество цифр в числе
// Console.WriteLine("Введите число");
// string number = Console.ReadLine();
// int Count=number.Length;
// Console.WriteLine(Count);
Console.Write("Введите число");
int num = int.Parse(Console.ReadLine());
int c = GetCountNum (num);
int GetCountNum(int number)
{
    int count = 0;
    while(number>0)
    {
        count++;
        number/=10;
    }
    return count;
}