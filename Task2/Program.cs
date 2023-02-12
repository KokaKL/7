// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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
            System.Console.Write($" {array[i,j] }");
        }
        System.Console.WriteLine();
    }
    
}

PrintArray(array);
int m = InputInt("Введите строку");
int n = InputInt("Введите стобец");
System.Console.WriteLine($"Значение элемента -> {array[m-1,n-1]}");