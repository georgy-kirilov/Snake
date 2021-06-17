namespace Snake.Logic.Models
{
    using Snake.Logic.Common;
    using Snake.Logic.Contracts;

    using System.Collections.Generic;

    public class SnakeBody
    {
        private readonly LinkedList<BodyPiece> _bodyPieces = new LinkedList<BodyPiece>();
        private readonly IBodyPieceDrawer _bodyPieceDrawer;

        public SnakeBody(int headRow, int headColumn, Direction direction, IBodyPieceDrawer bodyPieceDrawer)
        {
            _bodyPieceDrawer = bodyPieceDrawer;
            _bodyPieces.AddFirst(new BodyPiece(headRow, headColumn, _bodyPieceDrawer));
            Direction = direction;
        }

        public Direction Direction { get; private set; }

        private BodyPiece Head => _bodyPieces.First.Value;

        public void Grow()
        {
            var lastBodyPiece = _bodyPieces.Last.Value;
            var newBodyPiece = new BodyPiece(lastBodyPiece.Position.Row, lastBodyPiece.Position.Column, _bodyPieceDrawer);

            switch (Direction)
            {
                case Direction.Up:
                    newBodyPiece.Position.Row++;
                    break;

                case Direction.Right:
                    newBodyPiece.Position.Column--;
                    break;

                case Direction.Down:
                    newBodyPiece.Position.Row--;
                    break;

                case Direction.Left:
                    newBodyPiece.Position.Column++;
                    break;
            }

            _bodyPieces.AddLast(newBodyPiece);
        }

        public void Move()
        {
            var previousBodyPiecePosition = Head.Position;
            var newHeadPosition = new Position(Head.Position.Row, Head.Position.Column);

            switch (Direction)
            {
                case Direction.Up:
                    newHeadPosition.Row--;
                    break;

                case Direction.Right:
                    newHeadPosition.Column++;
                    break;

                case Direction.Down:
                    newHeadPosition.Row++;
                    break;

                case Direction.Left:
                    newHeadPosition.Column--;
                    break;
            }

            _bodyPieces.First.Value.Position = newHeadPosition;

            foreach (var bodyPiece in _bodyPieces)
            {
                var currentBodyPiecePosition = bodyPiece.Position;
                bodyPiece.Position = previousBodyPiecePosition;
                previousBodyPiecePosition = currentBodyPiecePosition;
            }
        }

        public void Draw()
        {
            foreach (var bodyPiece in _bodyPieces)
            {
                bodyPiece.Draw();
            }
        }
    }
}
