using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD

=======
>>>>>>> add Database.cs
using System.Drawing;
using System.Resources;
/*
using NAVI;
using Newtonsoft.Json;
using RUN.Properties;*/

namespace NAVI
{
    public class Database
    {
        private static string FilePath = AppDomain.CurrentDomain.BaseDirectory;
        private static string  FileName = "shabs.sc";

        public static List<Scene> scenes = new List<Scene>();

        public static void Load()
        {
            //DESERIALIZE
            string contents = System.IO.File.ReadAllText(Path.Combine(FilePath, FileName));
            scenes = JsonConvert.DeserializeObject<List<Scene>>(contents);
            foreach (Scene scene in scenes)
            {
                using (var stream = new MemoryStream(scene.ImageData))
                {
                    scene.SceneImage = Image.FromStream(stream);
                }
            }
        }

        public static void Save()
        {
            foreach (Scene scene in scenes)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    scene.SceneImage.Save(stream, scene.SceneImage.RawFormat);
                    scene.ImageData = stream.ToArray();
                }
            }
            string contents = JsonConvert.SerializeObject(scenes);
            System.IO.File.WriteAllText(Path.Combine(FilePath, FileName), contents);
        }
    }
}
