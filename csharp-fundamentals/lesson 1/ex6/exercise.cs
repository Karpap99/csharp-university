partial class Exercise6
{
    static void Main()
    {
        Console.WriteLine("Enter words");
        string words = Console.ReadLine();
        string[] wordss = words.Split(" ");
        int numofwords = 0;
        for (int i = 0; i < wordss.Length; i++)
        {
            if (wordss[i] != "")
            {
                numofwords++;
            }
        }
        Console.WriteLine($"Колво слов: {numofwords}");

    }
}
