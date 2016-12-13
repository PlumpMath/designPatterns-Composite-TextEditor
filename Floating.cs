using System;

namespace TextEditor
{
    public class Floating : IGraphic
    {
        private Point location;
        private IParentControlled element;

        public Floating(IParentControlled element, Point location)
        {
            this.location = location;
            this.element = element;
        }

        public void Draw(Point point)
        {
            element.Draw(new Point(point.Xcoordinate + location.Xcoordinate, point.Ycoordinate + location.Ycoordinate));
        }
    }
}