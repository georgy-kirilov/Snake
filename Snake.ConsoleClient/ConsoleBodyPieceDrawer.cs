namespace Snake.ConsoleClient
{
    using System;
    using Snake.Logic.Models;
    using Snake.Logic.Contracts;

    public class ConsoleBodyPieceDrawer : IBodyPieceDrawer
    {
        public ConsoleBodyPieceDrawer(char bodyPieceSymbol = 'O', ConsoleColor color = ConsoleColor.DarkYellow)
        {
            BodyPieceSymbol = bodyPieceSymbol;
            Color = color;
        }

        public char BodyPieceSymbol { get; set; }

        public ConsoleColor Color { get; set; }

        public void drawBodyPiece(BodyPiece bodyPiece)
        {
            Console.SetCursorPosition(bodyPiece.Position.Column, bodyPiece.Position.Row);
            Console.ForegroundColor = Color;
            Console.Write(BodyPieceSymbol);
        }
    }
}
