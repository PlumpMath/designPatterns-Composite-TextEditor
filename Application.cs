using System;
using System.Collections.Generic;

namespace TextEditor
{
    public class Application
    {
        private List<Tuple<IParentControlled, Point>> graphics;

        public Application(List<Tuple<IParentControlled, Point>> graphics)
        {
            this.graphics = graphics;
        }

        public void Run()
        {
            foreach (var graphic in graphics)
            {
                graphic.Item1.Draw(graphic.Item2);
            }

            Console.WriteLine();
        }
    }
}