// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2


Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] Array = GetArray(rows, columns, 0, 10); 
PrintArray(Array);

Console.WriteLine("Для поиска элемента массива введите его индексы далее...");
Console.Write("Введите индекс строки: ");
int IDrows = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс столбца: ");
int IDcolumns = int.Parse(Console.ReadLine()!);

CheckIDArray();






void CheckIDArray(){
    if (IDrows > Array.GetLength(0) || IDcolumns > Array.GetLength(1)){
        Console.WriteLine($"Такого элемента нет в массиве! Размер массива не может превышать [{rows},{columns}].");
    } else {
        int number = Array[IDrows,IDcolumns];
        Console.WriteLine($"Элемент [{IDrows},{IDcolumns}] заданного массива является числом {number}.");
    }
    return;
}


int[,] GetArray (int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
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