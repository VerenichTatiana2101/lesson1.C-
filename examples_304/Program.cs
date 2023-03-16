// Четвёртый вид метода
// что-то принимает
// что-то возвращает

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; //резалт у нас изначально будет пустой строкой
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z"); //склеивает 10 z
Console.WriteLine(res);


