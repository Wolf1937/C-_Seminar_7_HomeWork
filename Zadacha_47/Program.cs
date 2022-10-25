// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4. +

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] Array = GetArray(rows, columns, -10, 10);
PrintArray(Array);


double[,] GetArray(int m, int n, double minValue, double maxValue){
    double[,] result = new double[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i,j] = new Random().NextDouble() * 10;
        }
    }
    return result;
}

void PrintArray(double[,] Array){
    for (int i = 0; i < Array.GetLength(0); i++){
        for (int j = 0; j < Array.GetLength(1); j++){
            Console.Write(string.Format("{0:F2}  ", Array[i,j]));
        }
        Console.WriteLine();
    }
}