using System.Globalization;

namespace Bones.Modules{

    internal class Qube{
        private Random random;
        public Qube()
        {
            random = new Random();
        }

        public int RollQube(){
            return random.Next(1, 7);
        }

        public void QubeAnimation(int roll, string playerName = "Player"){
            int rols = random.Next(6, 10);
            for (int i = 0; i < rols; i++){
                Console.Clear();
                Console.WriteLine(NumToQube(random.Next(1, 7)));
                Thread.Sleep(200);
            }
            Console.Clear();
            Console.WriteLine(NumToQube(roll));
            Console.WriteLine($"{playerName} rolled a {roll}!");
            Thread.Sleep(1000);
        }


        public int[] Dice(int num_of_cubes, string playerName = "Player"){
            int[] qubes = new int[num_of_cubes];
            for (int i = 0; i < num_of_cubes; i++){
                int roll = RollQube();
                QubeAnimation(roll, playerName);
                qubes[i] = roll;
            }
            return qubes;
        }
        

        public static string NumToQube(int a){
            switch (a)
            {
                case 1:
                    return  "|       |\n" +
                            "|   o   |\n" +
                            "|       |";
                case 2:
                    return  "|       |\n" +
                            "| o   o |\n" +
                            "|       |";
                case 3:
                    return  "|   o   |\n" +
                            "|       |\n" +
                            "| o   o |";
                case 4:
                    return  "| o   o |\n" +
                            "|       |\n" +
                            "| o   o |";
                case 5:
                    return  "|   o   |\n" +
                            "| o o o |\n" +
                            "|   o   |";
                case 6:
                    return  "| o   o |\n" + 
                            "| o   o |\n" +
                            "| o   o |";
                default:
                    return "Wrong number";
            }
        }
    }
}
