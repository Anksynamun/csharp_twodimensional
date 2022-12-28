// See https://aka.ms/new-console-template for more information
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(0, 100);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine(" ");
}
for (int j = 0; j < array.GetLength(1); j++)
{
    double avg = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avg += array[i, j];
    }
    avg = avg / array.GetLength(0);
    Console.WriteLine($"Среднее арифметическое {j+1}-го столбца равно " + Math.Round(avg, 1));
}