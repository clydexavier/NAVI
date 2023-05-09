using System.Drawing;
using System.Resources;
using NAVI;
using Newtonsoft.Json;
using RUN.Properties;

Console.WriteLine("Hello, World!");
string filePath = AppDomain.CurrentDomain.BaseDirectory;
string fileName = "shabs.sc";


Image i = Resources.grass;

List<Scene> scenes = new List<Scene>();
scenes.Add(new Scene(i, "DCST"));


string contents = JsonConvert.SerializeObject(scenes);
System.IO.File.WriteAllText(Path.Combine(filePath, fileName), contents);