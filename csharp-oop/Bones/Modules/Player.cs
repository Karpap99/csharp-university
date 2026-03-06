namespace Bones.Modules
{
    internal class Player
    {
        private string Name { get; set; }
        private int Score { get; set; }

        public Player(string name) {
            Name = name;
            Score = 0;
        }

        public string GetName() => Name;
        public int GetScore() => Score;
        public void AddScore(int score){
            Score += score;
        }
    }
}
