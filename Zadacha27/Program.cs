//Программа принимает на ввод число и выдает сумму его цифр
// void IndexSum(string Number)
// {
//     int sum =0;
//     for (int i=0; i<Number.Length; i++)
//     {
//         sum = sum + Number[i];
//         Console.WriteLine(sum);
//     }
//     Console.WriteLine($"Сумма цифр числа {Number} равна {sum}");
// }
// Console.WriteLine("Введите число");
// string A =Console.ReadLine();
// IndexSum(A);
Console.WriteLine("Введите число");
string A =Console.ReadLine();
int count =A.Length;
Console.WriteLine(count);
int sum = 0;
int i =0;
while (i<count)
{
    sum +=A[i];
    i++;
}
Console.WriteLine(sum);