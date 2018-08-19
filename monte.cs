public static int Seed = Environment.TickCount;
public static double MontePi(int n)
{
    var rand = new Random(Seed++);
    var count = 0;
    if (n < 1) return 0;
    for (int i = 0; i < n; i++)
    {
        var x = rand.NextDouble();
        var y = rand.NextDouble();
        if (x * x + y * y <= 1)
        {
            count++;
        }
    }
    return 4.0 * count / n;
}
