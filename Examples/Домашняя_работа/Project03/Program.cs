// Напишите программу, которая задаёт массив из 8 элементов и
//  выводит их на экран. Заполнение массива производит пользователь.

int[] Array = new int[8];

for (int i = 0; i < 8; i++ )
{
   Console.WriteLine($"Введите элемент массива под номером {i}");
   Array[i] = Convert.ToInt32(Console.ReadLine());
}
 /* for ( int i = 0; i < 8; i++)
{
    Console.Write(Array[i] + ", ");
}    
 
 */
for(int i = 0; i < 1; i++ )
{
    Console.Write("[" + Array[i]+ ", "); 
}
for(int i = 1 ; i < 7; i++ )
{
    Console.Write( Array[i] + ", ");
}
for(int i = 7; i < 8; i++ )
{
    Console.Write( Array[i] + "]");
}