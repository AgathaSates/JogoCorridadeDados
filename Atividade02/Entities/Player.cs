namespace Atividade02.Entities
{
    internal class Player
    {
        public string Name { get; set; }
        public int Position { get; set; }

        public Player()
        {
        }

        public Player(string name, int position)
        {
            Name = name;
            Position = 0;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
