// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// !!! Надеюсь, что я правильно понля ТЗ
int[] arrayRandom(int n) // n - количество элементов в массиве
{
    int[] result = new int[n];
    for (int i = 0; i < n; i++)
    {
        result[i] = new Random().Next(0,99);
    }
    return result;
}
void Print(int[] result)
{
    for (int i = 0; i < result.Length; i++)
    {
        System.Console.Write(result[i] + " ");
    }
}
Print(arrayRandom(8));