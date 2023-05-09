using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        //private static string  FileName = "";
        //private static string FileExtension = ".sc";

        public static List<Scene>? scenes = new List<Scene>();

        public static void Load(string filename)
        {
            //DESERIALIZE
            string contents = System.IO.File.ReadAllText(filename);
            scenes = JsonConvert.DeserializeObject<List<Scene>>(contents);

            foreach (Scene scene in scenes ?? new List<Scene>())
            {
                #pragma warning disable CS8604 // Possible null reference argument.
                using (var stream = new MemoryStream(scene.ImageData))
                {
                    #pragma warning disable CA1416 // Validate platform compatibility
                    scene.SceneImage = Image.FromStream(stream);
                    #pragma warning restore CA1416 // Validate platform compatibility
                }
                #pragma warning restore CS8604 // Possible null reference argument.
            }
        }

        public static void Save(string filename)
        {
            foreach (Scene scene in scenes ?? new List<Scene>())
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    #pragma warning disable CA1416 // Validate platform compatibility
                    scene.SceneImage.Save(stream, scene.SceneImage.RawFormat);
                    #pragma warning restore CA1416 // Validate platform compatibility
                    scene.ImageData = stream.ToArray();
                }
            }
            string contents = JsonConvert.SerializeObject(scenes);
            System.IO.File.WriteAllText(filename, contents);
        }
    }
}
