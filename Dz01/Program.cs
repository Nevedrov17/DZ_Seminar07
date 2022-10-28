Console.Clear();

Console.WriteLine("Введите количество строк :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов :");
int n = Convert.ToInt32(Console.ReadLine());

double [,] array = new double [m ,n];
for (int i = 0; i < array.GetLength(0); i++ )
{
    for (int j = 0; j < array.GetLength(1); j++ )
    {
         array[i,j] = new Random().Next(-10,10);
         array[i,j] =Math.Round(array[i,j]/3.0,1);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
