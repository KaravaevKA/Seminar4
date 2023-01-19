//Программа принимает на ввод число и выдает сумму его цифр
Console.WriteLine("Введите число");
int num =Convert.ToInt32(Console.ReadLine());
void IndexSum(int A)
{
    int sum = 0;
    int i = 1;
    while(A != 0)
    {
        while(i<A)
        {
            int b = A / i % 10;
            sum = sum + b;
            i = i*10;
        }
        Console.WriteLine(sum);
        break;
    }
}
IndexSum(num);