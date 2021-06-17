namespace Snake.WpfClient
{
    using Snake.Logic.Common;
    using Snake.Logic.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    public partial class MainWindow : Window
    {
        private readonly Canvas _canvas;

        public MainWindow()
        {
            InitializeComponent();
            _canvas = (Canvas)FindName("Canvas");
            var snakeBody = new SnakeBody(0, 0, Direction.Up, new PlainColorBodyPieceDrawer(_canvas));
            snakeBody.Grow();
            snakeBody.Grow();
            snakeBody.Grow();
            snakeBody.Grow();
            snakeBody.Draw();
        }
    }
}
