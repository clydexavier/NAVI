using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVI
{
    public class Building
    {
        public string Name;
        public static List<Scene>? Scenes = new List<Scene>();
        public static double[,]? AllDataPoints { get; set; }

        public Building(string name)
        {
            this.Name = name;

        }

        public static bool InitAllPaths()
        {
            //check if all datapoints in each scene are already commited
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            foreach (Scene scene in Scenes)
            {
                if (!scene.DatapointsCommited)
                {
                    return false;
                }
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            int dimension = 0;
            //count the number of datapoints in all Scenes
            foreach (Scene scene in Scenes)
            {
                dimension += scene.DataPoints.Count;
            }

            //initialize matrix for all the datapoints 
            AllDataPoints = new double[dimension, dimension];

            //set all the values to -1. not connected
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    AllDataPoints[i, j] = -1;
                }
            }
            //combines all the connections of the matrix in each scene
            int idx = 0;
            foreach (Scene scene in Scenes)
            {
                int limit = idx * scene.DataPoints.Count;
                for (int i = 0; i < scene.DataPoints.Count; i++)
                {
                    for (int j = 0; j < scene.DataPoints.Count; j++)
                    {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        AllDataPoints[i + limit, j + limit] = scene.Matrix[i, j];
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    }
                }
            }
            return true;
        }

        public void UncommitAllPath()
        {
            AllDataPoints = null;
        }
    }
}
