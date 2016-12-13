using System;
using System.Collections.Generic;
using System.Linq;

namespace TextEditor
{
    public class Paragraph : IParentControlled
    {
        private List<ParagraphLine> pLines = new List<ParagraphLine>();
        private int width;

        public Paragraph(int width)
        {
            this.width = width;
        }

        public void Add(IInline element)
        {
            if (pLines.Count == 0)
            {
                ParagraphLine pLine = new ParagraphLine();
                pLine.Add(element);
                pLines.Add(pLine);
            }
            else
            {
                ParagraphLine pLine = pLines.Last();
                if (pLine.Width + element.GetXCoordinateDelta() > width)
                {
                    pLine = new ParagraphLine();
                    pLine.Add(element);
                    pLines.Add(pLine);
                }
                else
                {
                    pLine.Add(element);
                }
            }
        }

        public void Draw(Point point)
        {
            int yOffset = 0;
            for (int i = 0; i < pLines.Count; i++)
            {
                pLines[i].Draw(new Point(point.Xcoordinate, point.Ycoordinate + yOffset));
                yOffset += pLines[i].Height + 1;
            }
        }
    }
}