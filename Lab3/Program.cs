//Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);

Console.Write("Введіть x (0 < x < 1): ");
float x = float.Parse(Console.ReadLine());

// Перевірка умови 0 < x < 1
if (x <= 0 || x >= 1)
{
    Console.WriteLine("Помилка: x не задовольняє умову 0 < x < 1.");
    return;
}

Console.Write("Введіть n: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введіть e: ");
double e = double.Parse(Console.ReadLine());

double sum = 0;
int k = 1;
double term = 0;

do
{
    term = Math.Pow(-1, k - 1) * Math.Pow(x, 2 * k - 1) / Factorial(2 * k - 1);
    sum += term;
    k++;
} while (Math.Abs(term) >= e && k <= n);

Console.WriteLine($"Сума ряду: {sum}");

double C = Math.Sin(x);
Console.WriteLine($"Контрольний вираз C: {C}");
    

    static double Factorial(int n)
{
    if (n == 0)
        return 1;
    double result = 1;
    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }
    return result;
}
