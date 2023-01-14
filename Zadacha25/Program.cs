//Возведение числа А в натуральную степень В
void Numpower(int NumA, int NumB) //Когда объявляется функция, после нее не надо ставить ";" (это для запоминания)
{
    int Odin = 1; //Число x в степени n, это единица, умноженная на x n раз (поэтому любое число в 0 степени равно 1)!
    int Res = 0;
    
    for (int i=1; i<=NumB; i++)
    {
        Res = Odin*NumA;
        Odin = NumA*Odin;
        Console.WriteLine(Res);
    }
    if(NumB!=0) 
    {
        Console.WriteLine($"Число {NumA} в степени {NumB} равно: {Res}");
    }
    else 
    {
        Console.WriteLine($"Число {NumA} в степени {NumB} равно: {1}");
    }
}
Console.WriteLine("Введите число А");
int A =Convert.ToInt32(Console.ReadLine());
Console. WriteLine("Введите число В");
int B =Convert.ToInt32(Console.ReadLine());
Numpower(A,B);