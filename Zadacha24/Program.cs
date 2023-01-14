Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(summa_(num));
// int summa_(int number)
// {
//     int sum=0;
//     for (int i=1; number>=i;i++)
//     {
//         sum+=i;
//     }
//     return sum;
// }
void GetSumNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= Math.Abs(number); i++)
    {
        sum += i;
    } 
    Console.WriteLine($"Cумма цифр от 1 до {Math.Abs(number)}: {sum}");
}


// GetSumNums(-5);
// GetSumNums(58);
// GetSumNums(25);
// GetSumNums(16);

Console.WriteLine("Введите число A");
int n = Convert.ToInt32(Console.ReadLine());
GetSumNums(n);

Console.WriteLine("Введите число A");
GetSumNums(Convert.ToInt32(Console.ReadLine()));
