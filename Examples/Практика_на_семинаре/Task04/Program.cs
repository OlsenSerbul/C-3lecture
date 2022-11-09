// Напишите программу, которая выводит массив из 8 элементов, заполненный 
// нулями и единицами в случайном порядке.[1,0,1,1,0,1,0,0]

int[] array = new int[8];


// заполняем массив элементами 0, 1 в случайном порядке
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);

}
// выводим массив на консоль
for ( int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}

// Можно попросить пользователя заполнить массив самостоятельно
// for (int i = 0; i < array.Length; i++ )
// {
// Console.WriteLine($"Введите элемент массива под номером {i}");
// array[i] = Convert.ToInt32(Console.ReadLine());
// }
