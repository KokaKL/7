// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

int InputInt(string massege)
{
    System.Console.WriteLine(massege);
    string n = Console.ReadLine();
    int N = Convert.ToInt32(n);
    return N;
}

int[,] array = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($" {array[i, j]}");
        }
        System.Console.WriteLine();
    }
}

double[] sum(int[,] arr)
{
    double[] avg = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            avg[j] += arr[i, j];
        }
        avg[i] = avg[i] / arr.GetLength(0);
        }
    return avg;
}

// void AVG(int[] arr)
// {
//     System.Console.Write("среднее арифметического каждого столбца = ");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.WriteLine(sum(arr));
//     }
// }
void PrintArrayForDoule(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
            System.Console.Write($" {array[i]}");
            System.Console.WriteLine();
    }
}

PrintArray(array);
double[] s = sum(array);
PrintArrayForDoule(s);
//System.Console.WriteLine($"Значение элемента -> {array[m-1,n-1]}");