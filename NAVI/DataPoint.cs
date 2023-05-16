using System.Drawing;

namespace NAVI
{
    public class DataPoint
    {
        public PointF Location { get; set; }
        public string Name { get; set; }
        public bool IsMain { get; set; }

        public DataPoint(PointF location, string name, bool isMain)
        {
            this.Location = location;
            this.Name = name;
            this.IsMain = isMain;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public override bool Equals(object? obj)
        {
            return (obj is string && obj.Equals(this.Name)) || (obj is DataPoint);
        }

    }
}