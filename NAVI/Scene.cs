using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
//using System.Net.Mime.MediaTypeNames;


namespace NAVI
{
    public class Scene
    {
        public string Name;

        public Image SceneImage { get; set; }
        public byte[] ImageData;

        public Scene(Image scene_image, string name)
        {
            this.Name = name;
            this.SceneImage = scene_image;
            
        }

    }
}
