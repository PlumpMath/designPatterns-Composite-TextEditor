using System;

namespace TextEditor
{
    public abstract class Line : IInline
    {
        protected int length;

        public Line(int length)
        {
            this.length = length;
        }

        public abstract void Draw(Point point);
        public abstract int GetXCoordinateDelta();
        public abstract int GetYCoordinateDelta();
    }
}