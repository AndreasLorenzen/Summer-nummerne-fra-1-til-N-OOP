using Summer_nummerne_fra_1_til_N;

internal class Program
{
    private static void Main(string[] args)
    {
        ISumBeregn Beregnsum = new Matematiske_udregning();
        int output = Beregnsum.Beregn(Convert.ToInt32(Console.ReadLine()));

        Console.WriteLine(output);

    }
}
