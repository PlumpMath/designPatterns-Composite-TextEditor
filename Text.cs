using System;

namespace TextEditor
{
    public class Text : IInline
    {
        private string text;

        public Text(string text)
        {
            this.text = text;
        }

        public void Draw(Point point)
        {
            Console.SetCursorPosition(point.Xcoordinate, point.Ycoordinate);
            
            Console.Write(text);
        }

        public int GetXCoordinateDelta()
        {
            return text.Length;
        }

        public int GetYCoordinateDelta()
        {
            return 0;
        }
    }
}