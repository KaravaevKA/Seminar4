//Написать программу, которая задает массив из 8 элементов, и выводит их на экран
int[] Task29 ()
{
    int size = 8;
    int[] NewMassive = new int [8];
    for (int i = 0; i<8; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        NewMassive[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i<8; i++)
    {
        Console.Write(NewMassive[i] + " ");
    }
    return NewMassive;
}
int[] TaskArray = Task29();

