partial class Exercise8
{
    static void Main()
    {
        string[] letters = new string[6] { "a", "о", "и", "ы", "у", "э" };
        string words = Console.ReadLine();
        int sum = 0;
        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                if (Convert.ToString(words[i]) == letters[j])
                {
                    sum++;
                }
            }
        }
        Console.WriteLine($"Колво гласных: {sum}");
    }
}