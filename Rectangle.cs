using System;

namespace TextEditor
{
    public class Rectangle : IInline
    {
        private int width = 0;
        private int height = 0;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw(Point point)
        {
            // print top line
            Console.SetCursorPosition(point.Xcoordinate + 1, point.Ycoordinate);
            for (int i = 0; i < width; i++)
            {
                Console.Write('_');
            }

            // print left line
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(point.Xcoordinate, point.Ycoordinate + i + 1);
                Console.WriteLine('|');
            }

            // print bottom line
            Console.SetCursorPosition(point.Xcoordinate + 1, point.Ycoordinate + height);
            for (int i = 0; i < width; i++)
            {
                Console.Write('_');
            }

            // print right line
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(point.Xcoordinate + width + 1, point.Ycoordinate + i + 1);
                Console.WriteLine('|');
            }
        }

        public int GetXCoordinateDelta()
        {
            return width + 2;
        }

        public int GetYCoordinateDelta()
        {
            return height;
        }
    }
}