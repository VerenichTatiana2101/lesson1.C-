//1. метод заполнения массива
//2. метод печати массива на экран
//3. метод поиска определённого индекса числа в массиве

int[] array = new int[10]; //создай новый массив, в котором будет 10 элементов

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;  ///т.к если написать 0, если вводится число которого нет в массиве, 
    while (index < count)                          //он выставляет индекс 0, а 0 это первое число массива
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }

    return position;
}

FillArray(array);
//array[6] = 4; можно довнести число в массив вручную
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);



