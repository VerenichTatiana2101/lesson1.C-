// Упорядочить массив (данные внутри массива)
// алгоритм сортировки методом выбора (метод мини макс-а)


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)   //не больше пяти аргументов
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int teporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = teporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);