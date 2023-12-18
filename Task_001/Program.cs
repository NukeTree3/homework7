// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

int input()
{
    Console.Write("Введите значение: ");
    return Convert.ToInt32(Console.ReadLine());
}

void prom(int M, int N)
{
    if (M > N) return;
    Console.Write(M + " ");
    prom(M + 1, N);
}

int M = input();
int N = input();
prom(M, N);