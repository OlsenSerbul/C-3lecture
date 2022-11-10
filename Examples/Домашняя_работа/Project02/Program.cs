//  Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.

int FindSum (int number)
{
    string strNumber = number.ToString();
     
    int sum = 0;
    for (int i = 0; i < strNumber.Length; i++ )
    {
        sum = sum + Convert.ToInt32(strNumber[i].ToString());
         
    }
    return sum;
}
Console.Write("Введите число :  ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = FindSum (number);
Console.WriteLine(sum);



