using System.Globalization;

namespace Bones.Modules
{
    internal class Game
    {
        public Game()
        {
            ShowMenu();
        }


        public void ShowMenu()
        {
            Console.WriteLine("\tQUBES\n\n1.START\n2.EXIT");
            int g = int.Parse(Console.ReadLine());
            switch (g)
            {
                case 1:
                    StartGame();
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }

        public void SetParams<T>(string paramName, out T param)
        {
            T temp = default!;
            Console.WriteLine($"Set {paramName}! Current {paramName} is {temp} \n");
            string input = Console.ReadLine() ?? "";

            if (typeof(T) == typeof(int))
            {
                temp = (T)(object)int.Parse(input);
            }
            else if (typeof(T) == typeof(string))
            {
                temp = (T)(object)input;
            }
            else
            {
                throw new NotSupportedException($"Type {typeof(T)} not supported");
            }

            Console.WriteLine("You sure? 1/0");
            int ans = int.Parse(Console.ReadLine() ?? "0");

            if (ans != 1)
            {
                SetParams(paramName, out param);
            }
            else
            {
                param = temp;
            }
        }

        public void StartGame()
        {
            int maxScore;
            int numOfDices;
            int numOfPlayers;
            

            SetParams("MaxScore", out maxScore);
            Console.Clear();

            SetParams("number of dices", out numOfDices);
            Console.Clear();

            SetParams("number of players", out numOfPlayers);
            Console.Clear();

            Player[] players = new Player[numOfPlayers];
            
            for(int i = 0; i < numOfPlayers; i++)
            {
                string name;
                SetParams($"name of player {i + 1}", out name);
                Console.Clear();
                players[i] = new Player(name);
            }

            bool gameLoop = true;
            Qube qube = new Qube();

            while (gameLoop)
            {
                for(int i = 0; i < numOfPlayers; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"Player {players[i].GetName()}'s turn. Current score: {players[i].GetScore()}");
                    int[] dices = qube.Dice(numOfDices, players[i].GetName());
                    int TurnScore = 0;
                    foreach (int dice in dices)
                    {
                        TurnScore += dice;
                    }
                    players[i].AddScore(TurnScore);
                    Console.WriteLine($"Turn score: {TurnScore}. Total score: {players[i].GetScore()}");
                    
                    if (players[i].GetScore() >= maxScore)
                    {
                        Console.WriteLine($"Player {players[i].GetName()} wins!");
                        gameLoop = false;
                        break;
                    }
                    Thread.Sleep(2000);
                }
            }
            ShowMenu();


        }
    }
}