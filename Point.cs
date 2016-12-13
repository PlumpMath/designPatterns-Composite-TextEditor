namespace TextEditor
{
    public class Point
    {
        public int Xcoordinate { get; set; }
        public int Ycoordinate { get; set; }

        public Point(int xcoordinate, int ycoordinate)
        {
            this.Xcoordinate = xcoordinate;
            this.Ycoordinate = ycoordinate;
        }
    }
}