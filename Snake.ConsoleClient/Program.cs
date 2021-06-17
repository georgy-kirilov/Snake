namespace Snake.ConsoleClient
{
    using System;
    using Snake.Logic.Common;
    using Snake.Logic.Models;

    public class Program
    {
        public static void Main()
        {
            var snakeBody = new SnakeBody(0, 0, Direction.Up, new ConsoleBodyPieceDrawer());
            snakeBody.Grow();
            snakeBody.Grow();
            snakeBody.Grow();
            snakeBody.Draw();
        }
    }
}
