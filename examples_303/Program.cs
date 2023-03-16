// Третий вид метода
// ничего не принимает
// что-то возвращает.
// служат, например, чтобы генерировать какие-то случайные данные

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);