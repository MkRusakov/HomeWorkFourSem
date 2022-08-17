//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int funct(int num)
{
    int b = 0;
    string str_num = Convert.ToString(num);
    for (int i = 0; i < str_num.Length; i++)
    {
        int a = Convert.ToInt32(str_num[i].ToString());
        b = b + a;
    }
    return b;
}
System.Console.WriteLine(funct(55));
