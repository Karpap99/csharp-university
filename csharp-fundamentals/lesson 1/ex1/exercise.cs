
partial class Exercise1
{
    static void Main()
    {
        Random random = new Random();
        int Even = 0;
        int Odd = 0;
        int Unique = 0;
        int[] numbers = new int[20];

        for (int i = 0; i < 20; i++) numbers[i] = random.Next(40);

        bool uni = true;

        for (int i = 0; i < 20; i++)
        {
           uni = true;
           if (numbers[i] % 2 == 0) Even++;
           else Odd++;
           for (int j = 0; j < 20; j++)
           {
               if (numbers[i] == numbers[j] & i != j)
               {
                   uni = false;
                   break;
               }
           }
           if (!uni) Unique++;
        }

        for (int i = 0; i < 20; i++) Console.WriteLine(numbers[i] + " ");


        Console.WriteLine("Четные-" + Even);
        Console.WriteLine("Не четные-" + Odd);
        Console.WriteLine("Уникальние-" + Unique);
    }
}
