// Прием числа и вывод произведение чисел от 1 до N
void GetSumNums(int number)
{
    int sum = 1;
    for (int i = 2; i <=number; i++)
    {
        sum *= i;
    } 
    Console.WriteLine($"Произведение чисел от 1 до {number}: {sum}");
}
Console.WriteLine("Введите число A");
int n = Convert.ToInt32(Console.ReadLine());
GetSumNums(n);