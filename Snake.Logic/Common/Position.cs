namespace Snake.Logic.Common
{
    using System;

    public class Position
    {
        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public int Row { get; set; }

        public int Column { get; set; }

        public bool Equals(Position other)
        {
            return other != null && Row == other.Row && Column == other.Column;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Position);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column);
        }
    }
}
