// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами  

double random()
{
    double number = new Random().Next(0, 11) + new Random().NextDouble();
    System.Console.Write(number + " ");
    return number;
}

int InputInt(string massege)
{
    System.Console.WriteLine(massege);
    string n = Console.ReadLine();
    int N = Convert.ToInt32(n);
    return N;
}

int m = InputInt("Введите количество строк");
int n = InputInt("Введите количество стобцов");
double[,] matrix = new double[m,n];

void input_array(double[,] array)
{
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random();
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j] }");
        }
    }
    System.Console.WriteLine();
}

input_array(matrix);
PrintArray(matrix);