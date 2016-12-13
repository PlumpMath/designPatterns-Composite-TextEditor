using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextEditor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            HorizontalLine hLine1 = new HorizontalLine(1);
            HorizontalLine hLine2 = new HorizontalLine(2);
            HorizontalLine hLine3 = new HorizontalLine(3);
            HorizontalLine hLine4 = new HorizontalLine(4);
            HorizontalLine hLine5 = new HorizontalLine(5);
            HorizontalLine hLine6 = new HorizontalLine(6);

            VerticalLine vLine1 = new VerticalLine(1);
            VerticalLine vLine2 = new VerticalLine(2);
            VerticalLine vLine3 = new VerticalLine(3);
            VerticalLine vLine4 = new VerticalLine(4);
            VerticalLine vLine5 = new VerticalLine(5);

            Rectangle rect1 = new Rectangle(3, 2);
            Rectangle rect2 = new Rectangle(5, 3);

            Text space = new Text(" ");
            Text text1 = new Text("Hello World!!!");
            Text text2 = new Text("Zvezda Oleee!!!");
            Text text3 = new Text("Ne");
            Text text4 = new Text("Da");
            Text text5 = new Text("Ola");
            Text text6 = new Text("goodnight");

            Picture simplePic = new Picture(8, 6);
            Floating float1 = new Floating(hLine5, new Point(2, 2));
            Floating float2 = new Floating(vLine2, new Point(4, 3));
            simplePic.Add(float2);
            simplePic.Add(float1);

            Paragraph paragraph = new Paragraph(30);
            paragraph.Add(vLine4);
            paragraph.Add(text1);
            paragraph.Add(space);
            paragraph.Add(text2);
            paragraph.Add(hLine3);
            paragraph.Add(vLine2);
            paragraph.Add(space);
            paragraph.Add(rect2);
            paragraph.Add(hLine2);
            paragraph.Add(space);
            paragraph.Add(hLine1);
            paragraph.Add(space);
            paragraph.Add(text5);
            paragraph.Add(text4);
            paragraph.Add(space);
            paragraph.Add(text6);
            paragraph.Add(simplePic);
            paragraph.Add(vLine5);
            paragraph.Add(simplePic);
            paragraph.Add(space);
            paragraph.Add(text1);

            new Application
                (
                    new List<Tuple<IParentControlled, Point>>()
                    {
                        new Tuple<IParentControlled, Point>(paragraph, new Point(0, 0))
                    }
                )
                .Run();

            Console.CursorLeft = 0;
            Console.CursorTop = 25;
        }
    }
}
