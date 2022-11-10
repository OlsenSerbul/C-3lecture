/* Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.*/
// Просим ввести число
Console.Write("Введите число А:  ");
int number = Convert.ToInt32(Console.ReadLine());
// Переводит число в строку, но берем по модулю
string strNumber = Math.Abs(number).ToString();
Console.WriteLine(strNumber.Length);


