// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
double fun(int a, int b)
{
    double res = Math.Pow(a,b);
    return res;
}
System.Console.WriteLine(fun(3,5));
