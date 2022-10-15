// Задача 27: Напишите функцию и запустите ее, которая
// принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int SumNumbers(int a)
{
    int sum = 0;
    if (a == 0)
    {
        return 0;
    }
    while (a != 0)
    {
        sum = sum + a % 10;
        a = a / 10;
    }
    return sum;
    
}
Console.Clear();
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNumbers(A));