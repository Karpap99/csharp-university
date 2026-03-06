
partial class Exercise2
{
    static void Main()
    {
        Random random = new Random();
        int[] numbers = new int[20];
        int ElementsNum = 0;
        for (int i = 0; i < 20; i++) 
        {
            numbers[i] = random.Next(40);
        }
        Console.WriteLine("Type a num >");
        try
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] < num) 
                    ElementsNum++;
            Console.WriteLine($"Колво елементов меньше {num}: {ElementsNum}");
        }
        catch (Exception) { Console.WriteLine("is not number"); }
    }
}

