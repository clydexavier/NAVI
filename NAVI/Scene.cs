﻿using System;
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

        public Scene(Image scene_image, string name)
        {
            this.Name = name;
            this.SceneImage = scene_image;
            this.ImageData = null;
            this.DataPoints = new List<DataPoint>();
        }

        public override string ToString()
        {
            return this.Name; 
        }
    }
}
