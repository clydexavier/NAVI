namespace NAVI
{
    public class DataPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }

        public DataPoint(double x, double y, string name)
        {
            this.X = x;
            this.Y = y;
            this.Name = name;
        }
    }
}