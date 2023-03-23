// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(f-2)

double Fiboacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fiboacci(n-1) + Fiboacci(n-2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f{i} = {Fiboacci(i)}");
}
