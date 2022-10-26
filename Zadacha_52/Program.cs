// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Введите количестов строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] Array = GetArray(rows, columns, 0, 10);
PrintArray(Array);
Console.Write("Среднее арифмитеческое по каждому столбцу: ");

for (int j = 0; j < Array.GetLength(1); j++){
        double AvrColumns = 0;
        for (int i = 0; i < Array.GetLength(0); i++){
            AvrColumns = (AvrColumns + Array[i, j]);
        }
    AvrColumns = AvrColumns / rows;
    Console.Write(string.Format("{0:F1}  ", AvrColumns));
}
Console.WriteLine();




int[,] GetArray (int rows, int columns, int minValue, int maxValue){
    int[,] result = new int[rows,columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] Array){
    for (int i = 0; i < Array.GetLength(0); i++){
        for (int j = 0; j < Array.GetLength(1); j++){
            Console.Write($"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
}
