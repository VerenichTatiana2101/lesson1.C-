// двумерный массив
// индексы, как для строк, так и для столбцов идут с нуля
// table[0, 0]    table[0, 1]    table[0, 2]      table[0, 3]     table[0, 4]
// table[1, 0]    table[1, 1]    table[1, 2]      table[1, 3]     table[1, 4]

//String.Empty
// string[,] table = new string[2, 5];   //две строчки, 5 столбцов
// table[1, 2] = "слово";                //1 - индекс строки, 2 индекс столбца

// for (int rows = 0; rows < 2; rows++)   //колличество строк не больше двух
// {
//     for (int columns = 0; columns < 5; columns++)    //не больше пяти столбцов
//     {
//         Console.WriteLine($"~~{table[rows, columns]}~~");
//     }
// }

// int[,] matrix = new int[3, 4];
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
// Console.WriteLine();
// }

void PrintArray(int[,] matr)     //метод вывода матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++)   //возвращает кол-во строк в массиве
    {
        for (int j = 0; j < matr.GetLength(1); j++)   //возвращает кол-во столбцов в массиве
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)          //случайное заполнение матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); //[1, 10)
        }      
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);