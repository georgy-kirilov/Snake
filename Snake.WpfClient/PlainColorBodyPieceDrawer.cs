namespace Snake.WpfClient
{
    using Snake.Logic.Models;
    using Snake.Logic.Contracts;
    using System.Windows.Controls;
    using System.Windows.Shapes;
    using System.Windows.Media;

    public class PlainColorBodyPieceDrawer : IBodyPieceDrawer
    {
        public const int DefaultBodyPieceHeight = 30;
        public const int DefaultBodyPieceWidth = 30;

        private readonly Canvas _canvas;
        private readonly Brush _brush;

        public PlainColorBodyPieceDrawer(Canvas canvas) 
            : this(canvas, Brushes.Blue, DefaultBodyPieceHeight, DefaultBodyPieceWidth)
        {
        }

        public PlainColorBodyPieceDrawer(Canvas canvas, Brush brush, int bodyPieceHeight, int bodyPieceWidth)
        {
            _canvas = canvas;
            BodyPieceHeight = bodyPieceHeight;
            BodyPieceWidth = bodyPieceWidth;
            _brush = brush;
        }

        public int BodyPieceHeight { get; set; }

        public int BodyPieceWidth { get; set; }

        public void drawBodyPiece(BodyPiece bodyPiece)
        {
            var box = new Rectangle()
            {
                Height = BodyPieceHeight,
                Width = BodyPieceWidth,
                Fill = _brush,
            };
            
            Canvas.SetLeft(box, bodyPiece.Position.Column * BodyPieceWidth);
            Canvas.SetTop(box, bodyPiece.Position.Row * BodyPieceHeight);

            _canvas.Children.Add(box);
        }
    }
}
