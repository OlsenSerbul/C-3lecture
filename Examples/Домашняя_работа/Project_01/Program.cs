// Напишите программу, которая принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B
int GetPow (int A, int B)
{
    int resPow = 1;
    for (int i = 1; i <= B; i++ )
    {
        resPow = resPow * A;
    }
    return resPow;
}

Console.Write("Введите число А:  ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B:  ");
int B = Convert.ToInt32(Console.ReadLine());
// if (B <= 0) 
// {
//    Console.WriteLine("Вы ввели некорректное число. Натуральное - это целое и положительное число" );
//    return;   
// }

int resPow = GetPow (A, B);
Console.WriteLine(resPow);
