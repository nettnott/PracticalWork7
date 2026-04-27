using System;

int result = Fibonacci(5);
Console.WriteLine(result);

///<summary>
///Вычисляет n-ное число последовательности Фибоначчи
///</summary>
///<param name="n">Номер элемента последовательности</param>
/// <returns>Значение элемента номер n последовательности Фибоначчи</returns>
static int Fibonacci(int n)
{
    Console.WriteLine("The output is: ");
    int n1 = 0;
    int n2 = 1;
    int sum;

    for (int i = 2; i <= n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
    }

    return n == 0 ? n1 : n2;
}
