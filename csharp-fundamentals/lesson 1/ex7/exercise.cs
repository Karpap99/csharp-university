partial class Exercise7
{
    static void Main()
    {
        Console.WriteLine("Enter words:");
        string words = "";
        words += Console.ReadLine();
        string sdrow = "";
        for (int i = words.Length - 1; i >= 0; i--)
        {
            sdrow += words[i];
        }
        Console.WriteLine(sdrow);
    }
}