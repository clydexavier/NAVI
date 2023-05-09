using System.Drawing;
using System.Resources;
using NAVI;
using Newtonsoft.Json;
using RUN.Properties;

Console.WriteLine("Hello, World!");
string filePath = AppDomain.CurrentDomain.BaseDirectory;
string fileName = "shabs.sc";


/*Image i = Resources.grass;

List<Scene> scenes = new List<Scene>();
scenes.Add(new Scene(i, "DCST"));


string contents = JsonConvert.SerializeObject(scenes);
System.IO.File.WriteAllText(Path.Combine(filePath, fileName), contents);*/


List<Scene> scenes = new List<Scene>();

string contents = System.IO.File.ReadAllText(Path.Combine(filePath, fileName));
scenes = JsonConvert.DeserializeObject<List<Scene>>(contents);

using (var stream = new MemoryStream(scenes[0].ImageData))
{
    var image = Image.FromStream(stream);
    scenes[0].SceneImage = image;
    // Use the image object here
}

Console.WriteLine(scenes[0].Name);
Console.WriteLine(scenes[0].SceneImage.Height.ToString());