// циклы не только while
//for (цикл со счётчиком)
// 

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++) //сначало инициализация счётчика, далее проверка условия, инкримент i++
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);