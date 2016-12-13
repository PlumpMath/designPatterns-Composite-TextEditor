using System;

namespace TextEditor
{
    public class VerticalLine : Line
    {
        public VerticalLine(int length) : base(length)
        {
        }

        public override void Draw(Point point)
        {
            Console.SetCursorPosition(point.Xcoordinate, point.Ycoordinate);

            int cursorLeft = Console.CursorLeft;

            for (int i = 0; i < length; i++)
            {
                Console.CursorLeft = cursorLeft;
                Console.WriteLine('|');
            }
        }

        public override int GetXCoordinateDelta()
        {
            return 1;
        }

        public override int GetYCoordinateDelta()
        {
            return length - 1;
        }
    }
}