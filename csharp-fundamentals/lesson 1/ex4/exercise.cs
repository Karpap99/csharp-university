

partial class Exercise4
{
    static int UserInput()
    {
        while (true)
        {
            Console.WriteLine("Type M");
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("not a number");
            }
        }
    }
    static void Main()
    {

        Random random = new Random();
        int N = UserInput();
        int M = UserInput();

        int[,] arr1 = new int[N, M];
        int[,] arr2 = new int[N, M];
        int[,] arr3 = new int[N, M];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                arr1[i, j] = random.Next(100);
                arr2[i, j] = random.Next(100);
            }
        }

        bool contains = false;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                for (int g = 0; g < N; g++)
                {
                    for (int a = 0; a < M; a++)
                    {
                        if (arr1[i, j] == arr2[g, a])
                        {
                            for (int x = 0; x < N; g++)
                            {
                                for (int c = 0; c < M; g++)
                                {
                                    if (arr1[i, j] == arr3[x, c]) contains = true;
                                }
                            }
                            if (!contains)
                            {
                                for (int x = 0; x < N; g++)
                                {
                                    for (int c = 0; c < M; g++)
                                    {
                                        if (arr3[x, c] == null)
                                        {
                                            arr3[x, c] = arr1[i, j];
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}