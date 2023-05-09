using NAVI;

namespace GUI
{
    public partial class MainForm : Form
    {
        private static string? openedFileName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * Adds a new Scene to the ist of Scenes in found in the .sc (Scene) File 
             */
            ofd.Filter = "PNG File (*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Visible = true;
                string name = Microsoft.VisualBasic.Interaction.InputBox("Enter a name: ", "Add a scene");

                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                Database.scenes.Add(new Scene(Image.FromFile(ofd.FileName), name));
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
            } 
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * Where to save the file
             */
            sfd.Filter = "Scene File (*.sc)|*.sc";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Database.Save(sfd.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if you didn't open an existing file
            if(string.IsNullOrEmpty(openedFileName)) 
            {
                saveAsToolStripMenuItem_Click(sender, e);
                return;
            }
            //automatically saves the changes to the file that you opened
            Database.Save(openedFileName);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Scene File (*.sc)|*.sc";
            if(ofd.ShowDialog() == DialogResult.OK) 
            {
                string filename = ofd.FileName;
                openedFileName = ofd.FileName;
                Database.Load(filename);
                listBox1.DataSource= Database.scenes;
                listBox1.DisplayMember = "NAVI.Scene.Name";
                listBox1.Visible = true;
                //button1.Visible = true;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene? selectedScene = listBox1.SelectedItem as Scene;

            if (selectedScene == null) return; 
            
            //calculates the ratio of the PictureBox width and the Image width
            float scaleX = (float)pictureBox1.Width / pictureBox1.Image.Width;

            //calculates the ratio of the PictureBox height and the Image height
            float scaleY = (float)pictureBox1.Height / pictureBox1.Image.Height;

            //location of the click event with respect to the image's pixels instead of the PictureBox 
            float x_location = (float)e.X / scaleX;
            float y_location = (float)e.Y / scaleY;

            //if the image that is being displayed is not stretched
            if(pictureBox1.SizeMode == PictureBoxSizeMode.Normal)
            {
                //location of the click event with respect to the image's pixels if it is not being stretched
                x_location = (float)e.X;
                y_location = (float)e.Y;
            }

            PointF click = new PointF(x_location, y_location);

            //prompts the user to input the name of the newly added DataPoint
            string name = Microsoft.VisualBasic.Interaction.InputBox("Enter a name: ", "DataPoint name");

            //creation of the new DataPoint objects
            DataPoint dp = new DataPoint(click, name, false);

            //add the new DataPoint to the list of DataPoints
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            selectedScene.DataPoints.Add(dp);
            #pragma warning restore CS8602 // Dereference of a possibly null reference.
            Image i = selectedScene.SceneImage;

            using (Graphics g = Graphics.FromImage(i))
            {
                Brush brush = new SolidBrush(Color.Red);

                //paints a red dot to all the DataPoints
                foreach (DataPoint p in selectedScene.DataPoints)
                {
                    g.FillEllipse(brush, new Rectangle((int)p.Location.X, (int)p.Location.Y, 3, 3));
                }
            }
            //refreshes the image that is being displayed in the PictureBox
            pictureBox1.Image = i;
        }

        private void scenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * Displays the name of all the Scene that is inside the SceneFile (*.sc)
             * User can select a Scene in the list of Scenes
             */
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (Database.scenes.Count != 0)
            {
                pictureBox1.Visible = false;
                //button1.Visible = true;
                listBox1.Visible = true;
            }
            #pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            * Handles the event whenever the user selects a Scene in the list of Scenes
            * Displays the image of the Scene that is being selected
            */
            Scene? selectedScene = listBox1.SelectedItem as Scene;
            if (selectedScene != null)
            {
                listBox1.Visible = false;
                //button1.Visible = false;
                pictureBox1.Image = selectedScene.SceneImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Visible = true;

            }
        }
        /*private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
{
   *//*
    * Handles the event whenever the user selects a Scene in the list of Scenes
    * Displays the image of the Scene that is being selected
    *//*
   Scene? selectedScene = listBox1.SelectedItem as Scene;
   if(selectedScene != null)
   {
       listBox1.Visible = false;
       //button1.Visible = false;
       pictureBox1.Image = selectedScene.SceneImage;
       pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
       pictureBox1.Visible = true;

   }
}  */
    }
}