// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
Random rand = new Random();
int[] array = new int[rand.Next(1, 100)];

void ArrayCreate(int len)
{
    if (0 > len) return;
    array[len] = rand.Next(1, 100);
    ArrayCreate(len - 1);
}

void prom(int N, int[] array)
{
    if (0 > N) return;
    Console.Write(array[N] + " ");
    prom(N - 1, array);
}

ArrayCreate(array.Length-1);
prom(array.Length - 1, array);