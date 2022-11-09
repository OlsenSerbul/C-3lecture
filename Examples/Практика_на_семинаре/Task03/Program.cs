// Напишите программу, которая принимает на вход число N
//  и выдаёт произведение чисел от 1 до N.

int FindSqr (int number)
{
    int sqr = 1;
    for (int i = 1; i <= number; i++)
    {
        sqr = sqr * i;
    }
    return sqr;
}

Console.Write("Введите число А:  ");
int number = Convert.ToInt32(Console.ReadLine());

 int sqr = FindSqr (number);
 Console.WriteLine(sqr);



