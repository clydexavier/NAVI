using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.Text.Json;
using Newtonsoft.Json;


namespace NAVI
{
    public class Scene
    {
        public string Name;
        [JsonIgnore]
        public Image SceneImage { get; set; }
        public byte[]? ImageData;
        public List<DataPoint> DataPoints;
        public double[,]? Matrix;
        public bool DatapointsCommited;

        public Scene(Image scene_image, string name)
        {
            this.Name = name;
            this.SceneImage = scene_image;
            this.ImageData = null;
            this.DataPoints = new List<DataPoint>();
            this.DatapointsCommited = false;
        }

        public void InitPaths()
        {
            this.Matrix = new double[DataPoints.Count, DataPoints.Count];
            for(int i = 0; i < DataPoints.Count; i++) 
            {
                for(int j = 0; j < DataPoints.Count; j++)
                {
                    this.Matrix[i, j] = i == j ? 0 : -1;     
                }
            }
            this.DatapointsCommited = true;
        }

        public override string ToString()
        {
            return this.Name; 
        }
    }
}
