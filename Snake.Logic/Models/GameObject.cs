namespace Snake.Logic.Models
{
    using Snake.Logic.Common;

    public abstract class GameObject
    {
        public GameObject(int row, int column)
        {
            Position = new Position(row, column);
        }

        public Position Position { get; set;  }

        public abstract void Draw();
    }
}
