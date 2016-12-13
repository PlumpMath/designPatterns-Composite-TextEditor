using System;
using System.Collections.Generic;

namespace TextEditor
{
    public class ParagraphLine : IGraphic
    {
        private List<IInline> elements = new List<IInline>();

        public void Add(IInline element)
        {
            elements.Add(element);
        }

        public void Draw(Point point)
        {
            Point newPoint = new Point(point.Xcoordinate, point.Ycoordinate);

            foreach (var element in elements)
            {
                int xCoordinateDelta = element.GetXCoordinateDelta();
                int yCoordinateDelta = element.GetYCoordinateDelta();

                newPoint.Ycoordinate = point.Ycoordinate + Height - yCoordinateDelta;

                element.Draw(newPoint);
                newPoint.Xcoordinate = point.Xcoordinate + newPoint.Xcoordinate + xCoordinateDelta;
            }
        }

        public int Width
        {
            get
            {
                int width = 0;
                foreach (IInline element in elements)
                {
                    width += element.GetXCoordinateDelta();
                }

                return width;
            }
        }

        public int Height
        {
            get
            {
                int height = 0;
                foreach (var element in elements)
                {
                    if (element.GetYCoordinateDelta() > height)
                    {
                        height = element.GetYCoordinateDelta();
                    }
                }

                return height;
            }
        }
    }
}