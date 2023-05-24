using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Resources;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using System.ComponentModel;
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
        public static double[,]? AllDataPoints { get; set; }

        public static bool InitAllPaths()
        {
            foreach(Scene scene in scenes)
            {
                if (!scene.DatapointsCommited)
                {                    
                    return false;
                }
            }
            int dimension = 0;
            //count the number of datapoints in all Scenes
            foreach(Scene scene in scenes) 
            {
                dimension += scene.DataPoints.Count;
            }

            //initialize matrix for all the datapoints 
            AllDataPoints = new double[dimension, dimension];

            //set all the values to -1. not connected
            for(int i = 0; i < dimension; i++)
            {
                for(int j = 0; j < dimension; j++)
                {
                    AllDataPoints[i, j] = -1;
                }
            }
            //combines all the connections of the matrix in each scene
            int idx = 0;
            foreach(Scene scene in scenes)
            {
                int limit = idx * scene.DataPoints.Count;
                for(int i = 0; i < scene.DataPoints.Count; i++)
                {
                    for(int j = 0; j < scene.DataPoints.Count; j++)
                    {
                        #pragma warning disable CS8602 // Dereference of a possibly null reference.
                        AllDataPoints[i + limit, j + limit] = scene.Matrix[i, j];
                        #pragma warning restore CS8602 // Dereference of a possibly null reference.
                    }
                }
            }
            return true;
        }
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
