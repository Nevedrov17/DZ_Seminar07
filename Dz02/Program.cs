Console.Clear();

Console.WriteLine("Введите количество строк :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов :");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию строки :");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца :");
int y = Convert.ToInt32(Console.ReadLine());

double [,] array = new double [m ,n];
for (int i = 0; i < array.GetLength(0); i++ )
{
    for (int j = 0; j < array.GetLength(1); j++ )
    {
         array[i,j] = new Random().Next(0,100);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}

if ( x < array.GetLength(0) && y < array.GetLength(1))
{
for (int i = 0; i < array.GetLength(0); i++ )
{
    for (int j = 0; j < array.GetLength(1); j++ )
    {
        if (x ==i && y == j )
         {
            i = x;
            j = y;
            Console.WriteLine($"Значение заданного числа = {array[i,j]}");
         }
    }
}
}
else Console.WriteLine("Такого числа в массиве нет");