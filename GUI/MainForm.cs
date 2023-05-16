using NAVI;

namespace GUI
{
    public partial class MainForm : Form
    {
        private static string? openedFileName;
        private static bool addDatapointIsActivated = false;

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
                string name = Microsoft.VisualBasic.Interaction.InputBox("Enter a name: ", "Add a scene");

                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                Database.scenes.Add(new Scene(Image.FromFile(ofd.FileName), name));
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
                pictureBox1.Image = new Bitmap(Image.FromFile(ofd.FileName));
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Visible = true;
                listBox1.Visible = true;
                listBox1.DataSource = Database.scenes;
                listBox1.DisplayMember = "NAVI.Scene.Name";
                pictureBox1.Visible = true;
                panel2.Visible = true;
                UndoButton.Visible = true;
                DatapointButton.Visible = true;
                ConnectButton.Visible = true;
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
                pictureBox1.Visible = true;
                panel2.Visible = true;
                listBox1.Visible = true;
                UndoButton.Visible = true;
                DatapointButton.Visible = true;
                ConnectButton.Visible = true;
            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene? selectedScene = listBox1.SelectedItem as Scene;

            if (selectedScene == null || !addDatapointIsActivated) return;

            //calculates the ratio of the PictureBox width and the Image width
            float scaleX = (float)pictureBox1.Width / pictureBox1.Image.Width;

            //calculates the ratio of the PictureBox height and the Image height
            float scaleY = (float)pictureBox1.Height / pictureBox1.Image.Height;

            //location of the click event with respect to the image's pixels instead of the PictureBox 
            float x_location = (float)e.X / scaleX;
            float y_location = (float)e.Y / scaleY;


            
            PointF click = new PointF(x_location , y_location);

            //prompts the user to input the name of the newly added DataPoint
            string name = Microsoft.VisualBasic.Interaction.InputBox("Enter a name: ", "Add Datapoint");
            DialogResult result = MessageBox.Show("Is this a main Datapoint?", "Add Datapoint", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Cancel) return;

            //MessageBox.Show(click.X.ToString() + " " + click.Y.ToString());
            //MessageBox.Show(e.Location.ToString());

            //creation of the new DataPoint objects
            DataPoint dp = new DataPoint(click, name, result == DialogResult.Yes);

            //add the new DataPoint to the list of DataPoints
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            selectedScene.DataPoints.Add(dp);
            #pragma warning restore CS8602 // Dereference of a possibly null reference.

            pictureBox1.Image = selectedScene.SceneImage;

            Image i = new Bitmap(selectedScene.SceneImage);
            Font font = new Font("Arial", 6);


            //Image i = new Bitmap(selectedScene.SceneImage.Width, selectedScene.SceneImage.Height);
            using (Graphics g = Graphics.FromImage(i))
            {
                //Brush brush = new SolidBrush(Color.Red);
                //paints a red dot to all the DataPoints
                foreach (DataPoint p in selectedScene.DataPoints)
                {
                    float scale = pictureBox1.Width * 0.025f / 2;
                    PointF corrected = new PointF(p.Location.X - scale, p.Location.Y - scale);
                    if (p.IsMain)
                    {
                      
                       // g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, Font.Name, p.Location.X, p.Location.Y + 5);
                        g.FillEllipse(Brushes.Red, new RectangleF(corrected, new SizeF(2*scale, 2*scale)));
                        g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, font, Brushes.Black, p.Location.X, p.Location.Y + 5);
                    }
                    else
                    {
                        g.FillEllipse(Brushes.DarkGreen, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                        g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, font, Brushes.Black, p.Location.X, p.Location.Y + 5);
                    }
                       
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
                listBox1.DataSource = Database.scenes;
                listBox1.DisplayMember = "NAVI.Scene.Name";
                listBox1.Visible = true;
                panel2.Visible = true;
            }
            #pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Scene? selectedScene = listBox1.SelectedItem as Scene;
            if (selectedScene != null)
            {
                listBox1.Visible = true;
                pictureBox1.Image = selectedScene.SceneImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Visible = true;
                UndoButton.Visible = true;
                DatapointButton.Visible = true;
                ConnectButton.Visible = true;

                Image i = new Bitmap(selectedScene.SceneImage);
                Font font = new Font("Arial", 6);


                //Image i = new Bitmap(selectedScene.SceneImage.Width, selectedScene.SceneImage.Height);
                using (Graphics g = Graphics.FromImage(i))
                {
                    //Brush brush = new SolidBrush(Color.Red);
                    //paints a red dot to all the DataPoints
                    foreach (DataPoint p in selectedScene.DataPoints)
                    {
                        float scale = pictureBox1.Width * 0.025f / 2;
                        PointF corrected = new PointF(p.Location.X - scale, p.Location.Y - scale);
                        if (p.IsMain)
                        {

                            // g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, Font.Name, p.Location.X, p.Location.Y + 5);
                            g.FillEllipse(Brushes.Red, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                            g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, font, Brushes.Black, p.Location.X, p.Location.Y + 5);
                        }
                        else
                        {
                            g.FillEllipse(Brushes.DarkGreen, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                            g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, font, Brushes.Black, p.Location.X, p.Location.Y + 5);
                        }

                    }
                }
                //refreshes the image that is being displayed in the PictureBox
                pictureBox1.Image = i;
            }
        }

        private void dataPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene? selectedScene = listBox1.SelectedItem as Scene;
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (selectedScene == null || selectedScene.DataPoints.Count <= 0) return;

            listBox1.DataSource = selectedScene.DataPoints;
            listBox1.DisplayMember = "NAVI.DataPoint.Name";
            listBox1.Visible = true;
            panel2.Visible = true;
            UndoButton.Visible = true;
            DatapointButton.Visible = true;
            ConnectButton.Visible = true;
        
            #pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        private void DatapointButton_Click(object sender, EventArgs e)
        {
            if (addDatapointIsActivated)
            {
                addDatapointIsActivated = false;
                DatapointButton.BackColor = DefaultBackColor;
            }
            else
            {
                addDatapointIsActivated = true;
                DatapointButton.BackColor = Color.Yellow;
            }
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            Scene? selectedScene = listBox1.SelectedItem as Scene;
            if (selectedScene == null || selectedScene.DataPoints.Count <= 0) return;

            Image i = new Bitmap(selectedScene.SceneImage);
            Font font = new Font("Arial", 6);

            selectedScene.DataPoints.RemoveAt(selectedScene.DataPoints.Count - 1);
            //Image i = new Bitmap(selectedScene.SceneImage.Width, selectedScene.SceneImage.Height);
            using (Graphics g = Graphics.FromImage(i))
            {
                //Brush brush = new SolidBrush(Color.Red);
                //paints a red dot to all the DataPoints
                foreach (DataPoint p in selectedScene.DataPoints)
                {
                    float scale = pictureBox1.Width * 0.025f / 2;
                    PointF corrected = new PointF(p.Location.X - scale, p.Location.Y - scale);
                    if (p.IsMain)
                    {

                        // g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, Font.Name, p.Location.X, p.Location.Y + 5);
                        g.FillEllipse(Brushes.Red, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                        g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, font, Brushes.Black, p.Location.X, p.Location.Y + 5);
                    }
                    else
                    {
                        g.FillEllipse(Brushes.DarkGreen, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                        g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, font, Brushes.Black, p.Location.X, p.Location.Y + 5);
                    }

                }
            }
            //refreshes the image that is being displayed in the PictureBox
            pictureBox1.Image = i;
        }
    }
}