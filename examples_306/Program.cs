﻿// цикл в цикле
// в качестве примера таблица умножения

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j, 3} = {i*j, 3}");
    }
    Console.WriteLine();
}


