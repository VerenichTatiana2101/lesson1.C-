// факториал и рекурсия и переполнение

double Factorial(int n)
{
    if (n == 1) return 1;    //1! = 1  0! = 1
    else return n * Factorial(n - 1);
}

// Console.WriteLine(Factorial(3));   //1*2*3

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! {Factorial(i)}");
}