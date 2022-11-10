// Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.

int FindSum (int number)
{
    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.Write("Введите число А:  ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = FindSum(number);
Console.WriteLine(sum);

