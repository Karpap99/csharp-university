partial class Exercise9
{
    static void Main()
    {
        Console.WriteLine("Enter a words");
        string words = Console.ReadLine();
        Console.WriteLine("Enter a word");
        string word = Console.ReadLine();
        string[] wordds = words.Split(" ");
        int sumword = 0;

        for (int i = 0; i < wordds.Length; i++)
        {
            if (wordds[i] == word)
            {
                sumword++;
            }
        }
        Console.WriteLine($"Колво вхождений: {sumword}");

    }
}