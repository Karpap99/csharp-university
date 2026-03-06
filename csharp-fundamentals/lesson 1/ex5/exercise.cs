partial class Exercise5
{
    static void Main()
    {
        Random random = new Random();
        int[,] arr = new int[15, 15];
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                arr[i, j] = random.Next(100);
            }
        }
        int max = 0;
        int min = arr[0, 0];
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                Console.Write($"{arr[i, j]}\t");
                if (arr[i, j] > max) max = arr[i, j];
                if (arr[i, j] < min) min = arr[i, j];
            }
            Console.WriteLine();
        }

        Console.WriteLine($"MAX:{max} | MIN: {min}");

    }


}