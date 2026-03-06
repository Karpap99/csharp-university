partial class Exercise1
{
    double Pow(double x, double y)
    {
        double z = x;
        for (int i = 1; i < y; i++) x = x * z;
        return x;
    }

    int add(int x, int y)
    {
        int sum = 0;
        for (int i = x; i <= y; i++)
        {
            sum = sum + i;
        }
        return sum;
    }


    string divisions(int x)
    {
        List<int> numbs = new List<int>();
        int sum = 0;
        for (int i = x; i > 0; i--)
        {
            if (x % i == 0 & i != x)
            {
                numbs.Add(i);
                Console.WriteLine(i);
            }
        }
        for (int i = 0; i < numbs.Count(); i++)
        {
            sum = sum + numbs[i];
        }
        if (sum == x)
        {
            return "Совершеное";
        }
        else
        {
            return "Не совершеное";
        }
    }


    string drawCard(string symbol, int card_type)
    {
        string[] name = ["6", "7", "8", "9", "10", "А", "В", "Д", "К", "Т"];
        char[] suits = ['♠', '♥', '♦', '♣'];
        if (name.Contains(symbol))
            if (symbol == "10")
                return $"|{symbol}       |\n" +
                        "|         |\n" +
                       $"|    {suits[card_type]}    |\n" +
                        "|         |\n" +
                       $"|       {symbol}|";
            else
                return $"|{symbol}      |\n" +
                        "|       |\n" +
                        $"|   {suits[card_type]}   |\n" +
                        "|       |\n" +
                        $"|      {symbol}|";
    }

    string card(string name, string symbol)
    {
        int i;
        string g;
        switch (x)
        {
            case "Пика":
                i = 0;
                break;
            case "Чирва":
                i = 1;
                break;
            case "Бубна":
                i = 2;
                break;
            case "Трефа":
                i = 3;
                break;
            default:
                return "No card";
        }
        return drawCard(symbol, i);
    }

    string lucky_ticket(int x)
    {
        int[] ticket = new int[6];
        int k = x;
        if (x > 99999 & x <= 999999)
        {
            for (int i = 0; i < 6; i++)
            {
                ticket[i] = k % 10;
                k = k / 10;
            }
            if (ticket[0] + ticket[1] + ticket[2] == ticket[3] + ticket[4] + ticket[5])
            {
                return "Ticket is lucky";
            }
            else return "Ticket is not lucky";
        }
        else return "error: number too short or too long";
    }
    

    public override void Run()
    {
        Console.WriteLine(Pow(2, 2));
        Console.WriteLine(add(4, 7));
        Console.WriteLine(divisions(28));
        Console.WriteLine(card("Трефа", "T"));
        Console.WriteLine(lucky_ticket(6131641));
    }
}