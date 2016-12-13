using System;
using System.Collections.Generic;

namespace TextEditor
{
    public class Picture : IInline
    {
        private List<Floating> elements = new List<Floating>();
        private int width;
        private int height;

        public Picture(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw(Point point)
        {
            foreach (var element in elements)
            {
                element.Draw(point);
            }
        }

        public void Add(Floating element)
        {
            elements.Add(element);
        }

        public int GetXCoordinateDelta()
        {
            return width;
        }

        public int GetYCoordinateDelta()
        {
            return height;
        }
    }
}