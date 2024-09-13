public static class MainClass
{
    public static void Main(string[] args)
    {
        List<int> original = new List<int>();
        Random random = new Random(); 

        for (int i = 0; i < 10; i++)
        {
            var num = random.Next(1, 51);
            original.Add(num);
        }

        Console.WriteLine(string.Format("{0}", string.Join(", ", original)));
    }
}
