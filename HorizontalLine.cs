using System;

namespace TextEditor
{
    public class HorizontalLine : Line
    {
        public HorizontalLine(int length) : base(length)
        {
        }

        public override void Draw(Point point)
        {
            Console.SetCursorPosition(point.Xcoordinate, point.Ycoordinate);
            
            for (int i = 0; i < length; i++)
            {
                Console.Write('_');
            }
        }

        public override int GetXCoordinateDelta()
        {
            return length;
        }

        public override int GetYCoordinateDelta()
        {
            return 0;
        }
    }
}