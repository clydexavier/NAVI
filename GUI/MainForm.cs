using NAVI;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GUI
{
    /*
     * ILISTA TANAN SA LIST BOX ANG TANANG DATA POINTS SA TANANG SCENES SULOD SA USA KA .sc (SCENE FILE)
     * NAAY BUTTON NA MERGE PARA I MERGE TANANG DATA POINTS PARA MAUSA ANG TANANG MATRIX SA TANANG SCENES
     * 
     */
    public partial class MainForm : Form
    {
        private static string? openedFileName;
        private static bool addDatapointIsActivated = false;
        DataPoint? from;
        DataPoint? to;
        DataPoint? selectedDatapoint;
        Scene? selectedScene;

        public MainForm()
        {
            InitializeComponent();
        }

        private void populateDatapoint()
        {
            if (Database.scenes == null) return;
            //ListBoxDatapoints.Items.Clear();
            ListBoxDatapoints.Items.Clear();
            foreach(Scene scene in Database.scenes) 
            {
                foreach(DataPoint dp in scene.DataPoints) 
                {
                    ListBoxDatapoints.Items.Add(dp);
                }
            }
        }

        private void populateListBoxScenes()
        {
            if(Database.scenes == null) return;
            ListBoxScenes.Items.Clear();
            foreach(Scene scene in Database.scenes)
            {
                ListBoxScenes.Items.Add(scene);
            }
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

                Scene newScene = new Scene(Image.FromFile(ofd.FileName), name);
                Database.scenes.Add(newScene);
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
                selectedScene = newScene;
                PictureBoxSceneImage.Image = selectedScene.SceneImage;
                PictureBoxSceneImage.SizeMode = PictureBoxSizeMode.StretchImage;
                PictureBoxSceneImage.Visible = true;
                
                ListBoxScenes.Visible = true;
                populateListBoxScenes();
                ListBoxDatapoints.Visible = true;
                populateDatapoint();

               /* listBox1.DataSource = Database.scenes;
                listBox1.DisplayMember = "NAVI.Scene.Name";*/
 
                PictureBoxSceneImage.Visible = true;
                PanelListBox.Visible = true;
                selectedScene = Database.scenes[Database.scenes.Count - 1];

                //this.refreshAuxPanel();
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

        private void fillDataPoints() 
        {
            if (selectedScene == null) return;
            Image i = new Bitmap(selectedScene.SceneImage);


            //Image i = new Bitmap(selectedScene.SceneImage.Width, selectedScene.SceneImage.Height);
            using (Graphics g = Graphics.FromImage(i))
            {
                //Brush brush = new SolidBrush(Color.Red);
                //paints a red dot to all the DataPoints
                foreach (DataPoint p in selectedScene.DataPoints)
                {
                    float scale = PictureBoxSceneImage.Width * 0.025f / 2;
                    PointF corrected = new PointF(p.Location.X - scale, p.Location.Y - scale);
                    if (p.IsMain)
                    {
                      
                       // g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, Font.Name, p.Location.X, p.Location.Y + 5);
                        g.FillEllipse(Brushes.Blue, new RectangleF(corrected, new SizeF(2*scale, 2*scale)));
                        //g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, font, Brushes.Black, p.Location.X, p.Location.Y + 5);
                    }
                    else
                    {
                        g.FillEllipse(Brushes.DarkGreen, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                        //g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, font, Brushes.Black, p.Location.X, p.Location.Y + 5);
                    }
                       
                }
            }
            //refreshes the image that is being displayed in the PictureBox
            PictureBoxSceneImage.Image = i;
        }
        

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Scene File (*.sc)|*.sc";
            if(ofd.ShowDialog() == DialogResult.OK) 
            {
                string filename = ofd.FileName;
                openedFileName = ofd.FileName;
                Database.Load(filename);
                if (Database.scenes == null) return;
                MessageBox.Show("Success Open");
                populateListBoxScenes();
                ListBoxScenes.DisplayMember = "NAVI.Scene.Name";
                selectedScene = Database.scenes[0];
                PictureBoxSceneImage.Image = selectedScene.SceneImage;
                PictureBoxSceneImage.SizeMode = PictureBoxSizeMode.StretchImage;
                PictureBoxSceneImage.Visible = true;
                fillDataPoints();
                PanelListBox.Visible = true;
                ListBoxScenes.Visible = true;

                ListBoxDatapoints.Visible = true;
                populateDatapoint();

                //this.refreshAuxPanel();

                foreach (Scene scene in Database.scenes)
                {
                    MenuItemFileSceneView.DropDownItems.Add(scene.Name);
                }
            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedScene == null || !addDatapointIsActivated) return;

            MessageBox.Show("Click!");
            //calculates the ratio of the PictureBox width and the Image width
            float scaleX = (float)PictureBoxSceneImage.Width / PictureBoxSceneImage.Image.Width;

            //calculates the ratio of the PictureBox height and the Image height
            float scaleY = (float)PictureBoxSceneImage.Height / PictureBoxSceneImage.Image.Height;

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
            DataPoint dp = new DataPoint(click, name, result == DialogResult.Yes, selectedScene.ToString());

            //add the new DataPoint to the list of DataPoints
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            selectedScene.DataPoints.Add(dp);
            #pragma warning restore CS8602 // Dereference of a possibly null reference.

            PictureBoxSceneImage.Image = selectedScene.SceneImage;

            Image i = new Bitmap(selectedScene.SceneImage);
            Font font = new Font("Arial", 6);


            //Image i = new Bitmap(selectedScene.SceneImage.Width, selectedScene.SceneImage.Height);
            using (Graphics g = Graphics.FromImage(i))
            {
                //Brush brush = new SolidBrush(Color.Red);
                //paints a red dot to all the DataPoints
                foreach (DataPoint p in selectedScene.DataPoints)
                {
                    float scale = PictureBoxSceneImage.Width * 0.025f / 2;
                    PointF corrected = new PointF(p.Location.X - scale, p.Location.Y - scale);
                    if (p.IsMain)
                    {
                      
                       // g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, Font.Name, p.Location.X, p.Location.Y + 5);
                        g.FillEllipse(Brushes.Blue, new RectangleF(corrected, new SizeF(2*scale, 2*scale)));
                       // g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, font, Brushes.Black, p.Location.X, p.Location.Y + 5);
                    }
                    else
                    {
                        g.FillEllipse(Brushes.DarkGreen, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                        //g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, font, Brushes.Black, p.Location.X, p.Location.Y + 5);
                    }
                       
                }
            }
            //refreshes the image that is being displayed in the PictureBox
            PictureBoxSceneImage.Image = i;
            populateDatapoint();
        }

        private void scenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * Displays the name of all the Scene that is inside the SceneFile (*.sc)
             * User can select a Scene in the list of Scenes
             */
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (Database.scenes.Count <= 0) return;
            
            populateListBoxScenes();
            ListBoxScenes.DisplayMember = "NAVI.Scene.Name";
            ListBoxScenes.Visible = true;
            ListBoxDatapoints.Visible = true;
            populateDatapoint();
            PanelListBox.Visible = true;
            #pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            selectedScene = ListBoxScenes.SelectedItem as Scene;
            if (selectedScene == null) return;
    
            MessageBox.Show("Selected new scene.");
            ListBoxScenes.Visible = true;
            populateListBoxScenes();
            ListBoxDatapoints.Visible = true;
            populateDatapoint();
            PictureBoxSceneImage.Image = selectedScene.SceneImage;
            PictureBoxSceneImage.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxSceneImage.Visible = true;

            Image i = new Bitmap(selectedScene.SceneImage);
            Font font = new Font("Arial", 6);

            //Image i = new Bitmap(selectedScene.SceneImage.Width, selectedScene.SceneImage.Height);
            using (Graphics g = Graphics.FromImage(i))
            {
                //Brush brush = new SolidBrush(Color.Red);
                //paints a red dot to all the DataPoints
                foreach (DataPoint p in selectedScene.DataPoints)
                {
                    float scale = PictureBoxSceneImage.Width * 0.025f / 2;
                    PointF corrected = new PointF(p.Location.X - scale, p.Location.Y - scale);
                    if (p.IsMain)
                    {

                        // g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, Font.Name, p.Location.X, p.Location.Y + 5);
                        g.FillEllipse(Brushes.Blue, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                        //g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, font, Brushes.Black, p.Location.X, p.Location.Y + 5);
                    }
                    else
                    {
                        g.FillEllipse(Brushes.DarkGreen, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                        //g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, font, Brushes.Black, p.Location.X, p.Location.Y + 5);
                    }
                }
            }
            //refreshes the image that is being displayed in the PictureBox
            PictureBoxSceneImage.Image = i;
        }

        private void dataPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene? selectedScene = ListBoxScenes.SelectedItem as Scene;
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (selectedScene == null || selectedScene.DataPoints.Count <= 0) return;

            ListBoxScenes.DataSource = selectedScene.DataPoints;
            ListBoxScenes.DisplayMember = "NAVI.DataPoint.Name";
            ListBoxScenes.Visible = true;
            PanelListBox.Visible = true;
            ListBoxDatapoints.Visible = true;
            populateDatapoint();
            #pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        
        private void refresh()
        {
            if (selectedScene == null) return;
            Image i = new Bitmap(selectedScene.SceneImage);
            Font font = new Font("Arial", 6);

            //Image i = new Bitmap(selectedScene.SceneImage.Width, selectedScene.SceneImage.Height);
            using (Graphics g = Graphics.FromImage(i))
            {
                //Brush brush = new SolidBrush(Color.Red);
                //paints a red dot to all the DataPoints
                foreach (DataPoint p in selectedScene.DataPoints)
                {
                    float scale = PictureBoxSceneImage.Width * 0.025f / 2;
                    PointF corrected = new PointF(p.Location.X - scale, p.Location.Y - scale);
                    if (p.IsMain)
                    {

                        // g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, Font.Name, p.Location.X, p.Location.Y + 5);
                        g.FillEllipse(Brushes.Blue, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                        //g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, font, Brushes.Black, p.Location.X, p.Location.Y + 5);
                    }
                    else
                    {
                        g.FillEllipse(Brushes.Red, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                        //g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, font, Brushes.Black, p.Location.X, p.Location.Y + 5);
                    }
                }
            }
            //refreshes the image that is being displayed in the PictureBox
            PictureBoxSceneImage.Image = i;/*
            ListBoxScenes.Items.Clear();
            ListBoxScenes.DataSource = selectedScene.DataPoints;
            ListBoxScenes.DisplayMember = "NAVI.DataPoint.Name";*/
            ListBoxDatapoints.Visible = true;
            populateDatapoint();
        }
        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(selectedScene == null) return;

            //can't add more datapoints if already commited
            if(selectedScene.DatapointsCommited)
            {
                MessageBox.Show("Can't add since datapoints are already commited.");
                return;
            }
            if (addDatapointIsActivated)
            {
                addDatapointIsActivated = false;
                MenuItemAddDatapoint.Checked = false;
                MessageBox.Show("Success. Add deactivated");
            }
            else
            {
                addDatapointIsActivated = true;
                MenuItemAddDatapoint.Checked = true;
                MessageBox.Show("Success. Add activated");
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Scene? selectedScene = listBox1.SelectedItem as Scene;
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
            pictureBox1.Image = i;*/
            
            foreach(object o in ListBoxScenes.SelectedItems)
            {
                if (o is DataPoint)
                {
                    selectedScene.DataPoints.Remove(o as DataPoint);
                    
                }
            }
            this.refresh();
            
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(selectedScene == null)
            {
                MessageBox.Show("Selected scene is null.");
                return;
            }
            if(!selectedScene.DatapointsCommited)
            {
                MessageBox.Show("Datapoints of the current scene is not yet commited.");
                return;
            }
            this.refreshAuxPanel();
            

        }

        private void ListBoxScenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedScene = (Scene)ListBoxScenes.SelectedItem;
            MessageBox.Show("Index changed");
            if (selectedScene == null) return;

            MessageBox.Show("Selected new scene.");
            ListBoxScenes.Visible = true;
            populateListBoxScenes();
            ListBoxDatapoints.Visible = true;
            populateDatapoint();
            PictureBoxSceneImage.Image = selectedScene.SceneImage;
            PictureBoxSceneImage.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxSceneImage.Visible = true;

            Image i = new Bitmap(selectedScene.SceneImage);
            Font font = new Font("Arial", 6);

            //Image i = new Bitmap(selectedScene.SceneImage.Width, selectedScene.SceneImage.Height);
            using (Graphics g = Graphics.FromImage(i))
            {
                //Brush brush = new SolidBrush(Color.Red);
                //paints a red dot to all the DataPoints
                foreach (DataPoint p in selectedScene.DataPoints)
                {
                    float scale = PictureBoxSceneImage.Width * 0.025f / 2;
                    PointF corrected = new PointF(p.Location.X - scale, p.Location.Y - scale);
                    if (p.IsMain)
                    {

                        // g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, Font.Name, p.Location.X, p.Location.Y + 5);
                        g.FillEllipse(Brushes.Blue, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                        //g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, font, Brushes.Black, p.Location.X, p.Location.Y + 5);
                    }
                    else
                    {
                        g.FillEllipse(Brushes.DarkGreen, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                        //g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, font, Brushes.Black, p.Location.X, p.Location.Y + 5);
                    }
                }
            }
            //refreshes the image that is being displayed in the PictureBox
            PictureBoxSceneImage.Image = i;
        }

        private void MenuItemCommitSceneDatapoints_Click(object sender, EventArgs e)
        {
            if (selectedScene == null) return;
            selectedScene.InitPaths();
            MessageBox.Show($"Initializing {selectedScene.DataPoints.Count} by {selectedScene.DataPoints.Count} matrix");
        }

        private void MenuItemCommitAllDatapoints_Click(object sender, EventArgs e)
        {
            Database.InitAllPaths();
        }

        private void refreshAuxPanel()
        {
            LabelFrom.Visible = true;
            LabelTo.Visible = true;
            LabelDirection.Visible = true;
            LabelDistance.Visible = true;

            TextBoxDistance.Visible = true;
            ComboBoxToDatapoints.Visible = true;
            ComboBoxFromDatapoints.Visible = true;
            ComboBoxDirection.Visible = true;
            ButtonConnect.Visible = true;
            foreach (Scene sc in Database.scenes)
            {
                foreach(DataPoint p in sc.DataPoints) 
                {
                    ComboBoxFromDatapoints.Items.Add(p);
                    ComboBoxToDatapoints.Items.Add(p);
                }
            }

        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (selectedScene == null) 
            {
                MessageBox.Show("Selected scene is null");
                return;
            } 
            //check if all the fields are not empty
            if (ComboBoxFromDatapoints.SelectedIndex == -1 || ComboBoxToDatapoints.SelectedIndex == -1 || ComboBoxDirection.SelectedIndex == -1 || string.IsNullOrWhiteSpace(TextBoxDistance.Text))
            {
                MessageBox.Show("Input all the required field.");
                return;
            }

            DataPoint from = (DataPoint)ComboBoxFromDatapoints.SelectedItem;
            DataPoint to = (DataPoint)ComboBoxToDatapoints.SelectedItem;

            //check if from and two are the same datapoint
            if(from.Equals(to)) 
            {
                MessageBox.Show("Datapoints are the same");
                return;
            }

            //check if the datapoints are from the same scene
            if (!string.Equals(from.FromScene, to.FromScene ))
            {
                MessageBox.Show("Datapoints not from the same scene.");
                return;
            }

            //parse the string distance from the textbox to double 
            double distance = 0;
            if(!double.TryParse(TextBoxDistance.Text,out distance))
            {
                MessageBox.Show("Invalid input");
                return;
            }

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            selectedScene.Matrix[selectedScene.DataPoints.IndexOf(from), selectedScene.DataPoints.IndexOf(to)] = distance;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            if(ComboBoxDirection.SelectedIndex == 1)
            {
                selectedScene.Matrix[selectedScene.DataPoints.IndexOf(to), selectedScene.DataPoints.IndexOf(from)] = distance;
            }

            Image i = new Bitmap(PictureBoxSceneImage.Image);
            PointF correctedFrom = new PointF(from.Location.X, from.Location.Y);

            PointF correctedTo = new PointF(to.Location.X, to.Location.Y);

            //Image i = new Bitmap(selectedScene.SceneImage.Width, selectedScene.SceneImage.Height);
            using (Graphics g = Graphics.FromImage(i))
            {
                foreach(DataPoint dp in selectedScene.DataPoints) 
                {
                    float scale = PictureBoxSceneImage.Width * 0.025f / 2;
                    PointF corrected = new PointF(dp.Location.X - scale, dp.Location.Y - scale);
                    if (dp.IsMain)
                    {

                        // g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, Font.Name, p.Location.X, p.Location.Y + 5);
                        g.FillEllipse(Brushes.Blue, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                        //g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, font, Brushes.Black, p.Location.X, p.Location.Y + 5);
                    }
                    else
                    {
                        g.FillEllipse(Brushes.DarkGreen, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                        //g.DrawString("x: " + p.Location.X.ToString() + "\ny: " + p.Location.Y, font, Brushes.Black, p.Location.X, p.Location.Y + 5);
                    }
                }
                Pen p = new Pen(Color.Yellow, 5);
                g.DrawLine(p, correctedFrom, correctedTo);
            }
            //refreshes the image that is being displayed in the PictureBox
            PictureBoxSceneImage.Image = i;



            string output = $"Connecting {from.Name} and {to.Name} with distance {distance} meters. {(ComboBoxDirection.SelectedIndex == 0 ? "Directed" : "Undirected.")}";

            MessageBox.Show(output);




            /*if (selectedScene == null || !selectedScene.DatapointsCommited) return;
            MessageBox.Show("Selected scene not null. Datapoints commited");
            if (ListBoxDatapoints.SelectedItems.Count != 2) return;
            MessageBox.Show("Checked Items 2");
            // if (ListBoxDatapoints.SelectedItems[0].FromScene != ListBoxDatapoints.SelectedItems[1].FromScene) return;
            DataPoint from = (DataPoint)ListBoxDatapoints.SelectedItems[0];
            DataPoint to= (DataPoint)ListBoxDatapoints.SelectedItems[1];
            if(from == null || to == null) return;
            MessageBox.Show("Checked items not null");

            if (from.FromScene != to.FromScene) return;
            MessageBox.Show("Datapoints from same scene");

            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter distance from "+ from.Name + " to " + to.Name + " in meters." , "Distance");
            double distance;
            if(!double.TryParse(input, out distance))
            {
                MessageBox.Show("Invalid input");
                return;
            }

            DialogResult result = MessageBox.Show("Is this a directed edge?", "Distance", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Cancel) return;
            selectedScene.Matrix[selectedScene.DataPoints.IndexOf(from), selectedScene.DataPoints.IndexOf(to)] = distance;
            if (result  == DialogResult.No)
                selectedScene.Matrix[selectedScene.DataPoints.IndexOf(to), selectedScene.DataPoints.IndexOf(from)] = distance;

            string output = $"Connecting {from.Name} and {to.Name} with distance {distance} meters. {(result == DialogResult.Yes ? "Directed": "Undirected.")}";
            MessageBox.Show(output);*/
        }

        private void ComboBoxFromDatapoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxFromDatapoints_SelectedIndexChanged == null) return;
            from = (DataPoint)ComboBoxFromDatapoints.SelectedItem;


            Image i = PictureBoxSceneImage.Image;
            float scale = PictureBoxSceneImage.Width * 0.025f / 2;
            
            using (Graphics g = Graphics.FromImage(i))
            {
                foreach(DataPoint dp in selectedScene.DataPoints)
                {
                    PointF corrected = new PointF(dp.Location.X - scale, dp.Location.Y - scale);
                    if ((from != null && dp.Equals(from)) || (to != null && dp.Equals(to)))
                    {
                        g.FillEllipse(Brushes.Red, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                    }
                    else
                    {
                        g.FillEllipse(Brushes.Blue, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                    }
                }
            }

            PictureBoxSceneImage.Image = i;

        }

        private void ComboBoxToDatapoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxToDatapoints_SelectedIndexChanged == null) return;
            to = (DataPoint)ComboBoxToDatapoints.SelectedItem;

            Image i = PictureBoxSceneImage.Image;
            float scale = PictureBoxSceneImage.Width * 0.025f / 2;
            
            using (Graphics g = Graphics.FromImage(i))
            {
                foreach (DataPoint dp in selectedScene.DataPoints)
                {
                    PointF corrected = new PointF(dp.Location.X - scale, dp.Location.Y - scale);
                    if ((from != null && dp.Equals(from)) || (to != null && dp.Equals(to)))
                    {
                        g.FillEllipse(Brushes.Red, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                    }
                    else
                    {
                        g.FillEllipse(Brushes.Blue, new RectangleF(corrected, new SizeF(2 * scale, 2 * scale)));
                    }
                }
            }
            PictureBoxSceneImage.Image = i;
        }

        private void undoCommitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(selectedScene == null)
            {
                MessageBox.Show("Selected scene is null.");
                return;
            }
            selectedScene.Uncommit();
        }
    }
}