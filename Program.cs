// See https://aka.ms/new-console-template for more information

// 1 
void ShowNumbers(int n)
{
    if (n == 0)
    {
        Console.WriteLine(0);
        return;
    }

    if (n > 0)
    {
        ShowNumbers(n - 1);
        Console.WriteLine(n);
    }
}

ShowNumbers(5); // prints 0 1 2 3 4 5

// 2 
int SumArray(int[] nums, int pos)
{
    if (pos == nums.Length)
        return 0;

    return nums[pos] + SumArray(nums, pos + 1);
}

int[] values = { 1, 2, 3, 4 };
Console.WriteLine("Array sum: " + SumArray(values, 0));

// 3 
int AddUpTo(int n)
{
    if (n <= 0)
        return 0;

    return n + AddUpTo(n - 1);
}

Console.WriteLine("Sum to N: " + AddUpTo(5));

// 4 
string ReverseTxt(string txt, int pos)
{
    if (pos == txt.Length)
        return "";

    string rest = ReverseTxt(txt, pos + 1);
    return rest + txt[pos];
}

Console.WriteLine("Reversed: " + ReverseTxt("hello", 0));

// 5 
long Fact(int n)
{
    if (n <= 1)
        return 1;

    return n * Fact(n - 1);
}

Console.WriteLine("Factorial: " + Fact(5));

// 6 
long SuperFact(int n)
{
    long total = 1;

    for (int i = 1; i <= n; i++)
    {
        long temp = 1;
        for (int j = 1; j <= i; j++)
        {
            temp *= j;
        }
        total *= temp;
    }

    return total;
}

Console.WriteLine("Super factorial: " + SuperFact(4));

// 7 
int TetraSeq(int n)
{
    if (n == 0 || n == 1 || n == 2)
        return 0;
    if (n == 3)
        return 1;

    int[] t = new int[n + 1];
    t[0] = 0; t[1] = 0; t[2] = 0; t[3] = 1;

    for (int i = 4; i <= n; i++)
    {
        t[i] = t[i - 1] + t[i - 2] + t[i - 3] + t[i - 4];
    }

    return t[n];
}

Console.WriteLine("Tetranacci: " + TetraSeq(4));

// 8 
long CubesSum(int n)
{
    if (n <= 0)
        return 0;

    return (long)(n * n * n) + CubesSum(n - 1);
}

Console.WriteLine("Sum of cubes: " + CubesSum(3));

// 9 
int DigitsSum(int num)
{
    if (num == 0)
        return 0;

    int last = num % 10;
    int rest = num / 10;

    return last + DigitsSum(rest);
}

Console.WriteLine("Sum of digits: " + DigitsSum(123));

// 10 
int PellNum(int n)
{
    if (n == 0)
        return 0;
    if (n == 1)
        return 1;

    int[] p = new int[n + 1];
    p[0] = 0;
    p[1] = 1;

    for (int i = 2; i <= n; i++)
    {
        p[i] = 2 * p[i - 1] + p[i - 2];
    }

    return p[n];
}

Console.WriteLine("Pell number: " + PellNum(7));