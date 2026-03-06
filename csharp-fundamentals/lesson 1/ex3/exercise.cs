
partial class Exercise3
{
    static void Main()
    {
        int[] numbers = new int[10];
        int g = 0;
        Console.WriteLine("Вводите цифры");
        while (g != 10)
        {
            Console.WriteLine($"Цифра номер: {g + 1}");
            try
            {
                numbers[g] = int.Parse(Console.ReadLine());
                g++;
            }
            catch (Exception) { Console.WriteLine("Not a number"); }
        }
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            if (numbers[i] == 7)
            {
                if (numbers[i + 1] == 6)
                {
                    if (numbers[i + 2] == 5)
                    {
                        sum++;
                    }
                }
            }
        }
        Console.WriteLine($"Колво повторений {sum}");
    }
}