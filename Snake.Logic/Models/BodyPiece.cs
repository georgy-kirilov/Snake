namespace Snake.Logic.Models
{
    using Snake.Logic.Contracts;

    public class BodyPiece : GameObject
    {
        private readonly IBodyPieceDrawer _bodyPieceDrawer;

        public BodyPiece(int row, int column, IBodyPieceDrawer bodyPieceDrawer) : base(row, column)
        {
            _bodyPieceDrawer = bodyPieceDrawer;
        }

        public override void Draw()
        {
            _bodyPieceDrawer.drawBodyPiece(this);
        }
    }
}
