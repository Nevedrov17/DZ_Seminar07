Console.Clear();

Console.WriteLine("Введите количество строк :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов :");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [m ,n];
for (int i = 0; i < array.GetLength(0); i++ )
{
    for (int j = 0; j < array.GetLength(1); j++ )
    {
         array[i,j] = new Random().Next(0,10);
         Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}         
double sum = 0;
for (int j = 0; j < array.GetLength(1); j++ )
{
    for (int i = 0; i < array.GetLength(0); i++ )
    {
         sum = sum + array[i,j];
    }
    Console.Write($"{sum/m} ");
    sum = 0;
}         