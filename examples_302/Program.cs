// Второй вид метода
// что-то принимают
// ничего не возвращают.
// void метод

// void Method2(string msg)
// {
//     Console.WriteLine(mag);
// }
// Method2("Текст сообщения");

void Method2(string msg, int count)
{
    int i = 0;
    while(i< count)
    {
        Console.WriteLine(msg);
        i ++;
    }
    
}
Method2(msg: "Текст", count: 4); //пишет слово текст 4 раза(первый 
                    // аргумент msg "Текст", второй count введён 4)
//с указанием аргументов можно вписывать в вызов в разном порядке
